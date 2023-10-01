CREATE DATABASE training_courses;
USE training_courses;

CREATE TABLE `course` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `description` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `duration` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `price` double DEFAULT NULL,
  `idTeacher` int DEFAULT NULL,
  `idCourseplan` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `courseplan` (
  `id` int NOT NULL,
  `course_plan` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `listofparticipant` (
  `id` int NOT NULL,
  `idCourse` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `participant` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `number_passport` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `arrival_city` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_testing` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `participantinliat` (
  `id` int NOT NULL,
  `idParticipant` int DEFAULT NULL,
  `idList` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


CREATE TABLE `supervisor` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `course_dev` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `teacher` (
  `id` int NOT NULL,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `surname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `patronymic` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `number_passport` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `education` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `experience` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `test` (
  `id` int NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `idCourse` int DEFAULT NULL,
  `dataTest` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `users` (
  `id` int NOT NULL,
  `login` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idParticipant` int DEFAULT NULL,
  `idTeacher` int DEFAULT NULL,
  `idSupervisor` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

ALTER TABLE `course`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_teacher` (`idTeacher`),
  ADD KEY `id_coursePlan` (`idCourseplan`);

ALTER TABLE `courseplan`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `listofparticipant`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idCourse` (`idCourse`);

ALTER TABLE `participant`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_testing` (`id_testing`);

ALTER TABLE `participantinliat`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idParticipant` (`idParticipant`),
  ADD KEY `idList` (`idList`);

ALTER TABLE `supervisor`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `teacher`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `test`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`),
  ADD KEY `idCourse` (`idCourse`);

ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idParticipant` (`idParticipant`),
  ADD KEY `idTeacher` (`idTeacher`),
  ADD KEY `idSupervisor` (`idSupervisor`);

ALTER TABLE `course`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `courseplan`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `listofparticipant`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `participant`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `participantinliat`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `supervisor`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `teacher`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `test`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `course`
  ADD CONSTRAINT `course_ibfk_1` FOREIGN KEY (`idTeacher`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `course_ibfk_2` FOREIGN KEY (`idCourseplan`) REFERENCES `courseplan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `listofparticipant`
  ADD CONSTRAINT `listofparticipant_ibfk_2` FOREIGN KEY (`idCourse`) REFERENCES `course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `participant`
  ADD CONSTRAINT `participant_ibfk_1` FOREIGN KEY (`id_testing`) REFERENCES `testing` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `participantinliat`
  ADD CONSTRAINT `participantinliat_ibfk_1` FOREIGN KEY (`idParticipant`) REFERENCES `participant` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `participantinliat_ibfk_2` FOREIGN KEY (`idList`) REFERENCES `listofparticipant` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `test`
  ADD CONSTRAINT `test_ibfk_1` FOREIGN KEY (`idCourse`) REFERENCES `course` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`idParticipant`) REFERENCES `participant` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `users_ibfk_2` FOREIGN KEY (`idTeacher`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `users_ibfk_3` FOREIGN KEY (`idSupervisor`) REFERENCES `supervisor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

