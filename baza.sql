-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`ZAPOSLENI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ZAPOSLENI` (
  `JMBG` CHAR(13) NOT NULL,
  `ime` VARCHAR(20) NOT NULL,
  `prezime` VARCHAR(20) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `pasword` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `broj_telefona` CHAR(11) NOT NULL,
  `tema` INT NOT NULL,
  `jezik` INT NOT NULL,
  PRIMARY KEY (`JMBG`),
  UNIQUE INDEX `JMBG_UNIQUE` (`JMBG` ASC) VISIBLE,
  UNIQUE INDEX `broj_telefona_UNIQUE` (`broj_telefona` ASC) VISIBLE,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`NAKIT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`NAKIT` (
  `nakit_id` INT NOT NULL AUTO_INCREMENT,
  `gramaza` DOUBLE NOT NULL,
  `cijena` DECIMAL(8) NOT NULL,
  `naziv` VARCHAR(45) NOT NULL,
  `kolicina` INT NOT NULL,
  `ZAPOSLENI_JMBG` CHAR(13) NOT NULL,
  PRIMARY KEY (`nakit_id`),
  UNIQUE INDEX `nakit_id_UNIQUE` (`nakit_id` ASC) VISIBLE,
  INDEX `fk_NAKIT_ZAPOSLENI_idx` (`ZAPOSLENI_JMBG` ASC) VISIBLE,
  CONSTRAINT `fk_NAKIT_ZAPOSLENI`
    FOREIGN KEY (`ZAPOSLENI_JMBG`)
    REFERENCES `mydb`.`ZAPOSLENI` (`JMBG`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`KUPAC`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`KUPAC` (
  `kupac_id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `pasword` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `tema` INT NOT NULL,
  `jezik` INT NOT NULL,
  PRIMARY KEY (`kupac_id`),
  UNIQUE INDEX `kupac_id_UNIQUE` (`kupac_id` ASC) VISIBLE,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`KUPOVINA_STAVKA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`KUPOVINA_STAVKA` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `KUPAC_kupac_id` INT NOT NULL,
  `NAKIT_nakit_id` INT NOT NULL,
  PRIMARY KEY (`id`, `KUPAC_kupac_id`, `NAKIT_nakit_id`),
  INDEX `fk_KUPAC_has_NAKIT_NAKIT1_idx` (`NAKIT_nakit_id` ASC) VISIBLE,
  INDEX `fk_KUPAC_has_NAKIT_KUPAC1_idx` (`KUPAC_kupac_id` ASC) VISIBLE,
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  CONSTRAINT `fk_KUPAC_has_NAKIT_KUPAC1`
    FOREIGN KEY (`KUPAC_kupac_id`)
    REFERENCES `mydb`.`KUPAC` (`kupac_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_KUPAC_has_NAKIT_NAKIT1`
    FOREIGN KEY (`NAKIT_nakit_id`)
    REFERENCES `mydb`.`NAKIT` (`nakit_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
