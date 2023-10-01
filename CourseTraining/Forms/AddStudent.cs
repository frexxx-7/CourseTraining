using CourseTraining.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseTraining.Forms
{
    public partial class AddStudent : Form
    {
        private string idListofparticipant = "";
        private int quantityProduct;
        private string idCourse = null;
        public AddStudent(string idListofparticipant, string idCourse)
        {
            InitializeComponent();
            this.idListofparticipant = idListofparticipant;
            this.idCourse = idCourse;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            participantCbb.Items.Clear();
            DB db = new DB();

            string queryInfoParticipantCbb = $"SELECT * FROM participant";

            MySqlCommand mySqlCommandParticipantCbb = new MySqlCommand(queryInfoParticipantCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerParticipantCbb = mySqlCommandParticipantCbb.ExecuteReader();
            while (readerParticipantCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{readerParticipantCbb[1]} {readerParticipantCbb[2]} {readerParticipantCbb[3]} {readerParticipantCbb[4]} {readerParticipantCbb[5]}";
                item.Value = readerParticipantCbb[0];
                participantCbb.Items.Add(item);
            }
            readerParticipantCbb.Close();
            db.closeConnection();
            if (idCourse!=null)
            {
                string query = $"select participant.* FROM participantinliat " +
                    $"inner join participant on participantinliat.idParticipant = participant.id " +
                    $"WHERE idList = (select id from listofparticipant where idCourse = {idCourse}) ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                List<string[]> dataDB = new List<string[]>();
                while (reader.Read())
                {
                    dataDB.Add(new string[reader.FieldCount]);

                    dataDB[dataDB.Count - 1][1] = reader["id"].ToString();
                    dataDB[dataDB.Count - 1][0] = $"{reader[1]} {reader[2]} {reader[3]} {reader[4]} {reader[5]}";
                }
                reader.Close();
                foreach (string[] s in dataDB)
                    dataGridView1.Rows.Add(s);
                reader.Close();
                db.closeConnection();
            }
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[quantityProduct].Cells[0].Value = (participantCbb.SelectedItem as ComboboxItem).Text;
            dataGridView1.Rows[quantityProduct].Cells[1].Value = (participantCbb.SelectedItem as ComboboxItem).Value;
            participantCbb.SelectedIndex = -1;
            quantityProduct++;
        }

        private void savePatBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (idCourse != null)
            {
                MySqlCommand command3 = new MySqlCommand($"DELETE FROM participantinliat WHERE idList = (select id from listofparticipant where idCourse = {idCourse})", db.getConnection());
                db.openConnection();
                try
                {
                    command3.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
                db.closeConnection();
            }
            string query = "Insert into participantinliat (idParticipant, idList) values ";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                query += $"({dataGridView1.Rows[i].Cells[1].Value}, {idListofparticipant}), ";
            }
            query = query.Remove(query.Length - 2);
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            db.closeConnection();
           
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
    }
}
