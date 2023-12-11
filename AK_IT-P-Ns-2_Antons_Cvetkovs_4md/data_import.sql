CREATE DATABASE sport_club;

CREATE TABLE sport_club.dbo.client (
    personal_code VARCHAR(13)
        CHECK (
            LEN(personal_code) = 13 AND
            ISNUMERIC(SUBSTRING(personal_code, 1, 6)) = 1 AND
            SUBSTRING(personal_code, 7, 1) = '-' AND
            ISNUMERIC(SUBSTRING(personal_code, 8, 5)) = 1
        ),
    name VARCHAR(100),
    surname VARCHAR(100),
    email VARCHAR(255)
        CHECK (
            LEN(email) <= 255 AND email LIKE '%_@_%._%' AND email NOT LIKE '%@%@%' AND
            email NOT LIKE '%.@%' AND email NOT LIKE '%@.%' AND email NOT LIKE '%.%@%'
        ),
    phone_num INT CHECK (LEN(phone_num) = 8),
    CONSTRAINT client_pk PRIMARY KEY (personal_code)
);

CREATE TABLE sport_club.dbo.gym (
    id INT,
    address VARCHAR(100),
    CONSTRAINT gym_pk PRIMARY KEY (id)
);

CREATE TABLE sport_club.dbo.sport (
    id INT,
    name VARCHAR(100),
    CONSTRAINT sport_pk PRIMARY KEY (id)
);

CREATE TABLE sport_club.dbo.gym_sport (
    sport_id INT,
    gym_id INT,
    CONSTRAINT gym_sport_pk PRIMARY KEY (sport_id, gym_id),
    CONSTRAINT gym_sport_sport_id_fk FOREIGN KEY (sport_id) REFERENCES sport_club.dbo.sport (id),
    CONSTRAINT gym_sport_gym_id_fk FOREIGN KEY (gym_id) REFERENCES sport_club.dbo.gym (id)
);

CREATE TABLE sport_club.dbo.session (
    id INT,
    client VARCHAR(13),
    gym_id INT,
    date DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT session_id PRIMARY KEY (id),
    CONSTRAINT session_client_fk FOREIGN KEY (client) REFERENCES sport_club.dbo.client (personal_code),
    CONSTRAINT session_gym_id_fk FOREIGN KEY (gym_id) REFERENCES sport_club.dbo.gym (id)
);