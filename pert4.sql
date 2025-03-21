create database pabdpert3;

CREATE TABLE Mahasiswa (
    NIM CHAR(11) PRIMARY KEY,
    Nama VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Telepon VARCHAR(13) CHECK (Telepon LIKE '08%' AND LEN(Telepon) BETWEEN 10 AND 13),
    Alamat VARCHAR(255) NULL
);
