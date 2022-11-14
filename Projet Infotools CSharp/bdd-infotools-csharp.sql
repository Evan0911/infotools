-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Mar 18 Mai 2021 à 17:33
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe-infotools`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE `admin` (
  `id` int(10) NOT NULL,
  `identifiant` varchar(100) NOT NULL,
  `mdp` varchar(500) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `admin`
--

INSERT INTO `admin` (`id`, `identifiant`, `mdp`, `created_at`, `updated_at`) VALUES
(1, 'evan.lefevre108@gmail.com', '$2y$10$9bs5AzMBHljKlhnkrYFQiOSGR9ZBAqSd7HfUDmmmMiJuZ9LR5MfvW', NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

CREATE TABLE `clients` (
  `id` int(10) UNSIGNED NOT NULL,
  `prenomCli` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nomCli` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresseCli` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cpCli` varchar(5) COLLATE utf8mb4_unicode_ci NOT NULL,
  `villeCli` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telCli` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `mailCli` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Contenu de la table `clients`
--

INSERT INTO `clients` (`id`, `prenomCli`, `nomCli`, `adresseCli`, `cpCli`, `villeCli`, `telCli`, `mailCli`, `created_at`, `updated_at`) VALUES
(1, 'Courage', 'Satan', 'Rue des flammes', '00110', 'En faire', '7894561230', 'Satan.Courage@Hell.to', '2020-11-16 13:26:47', '2020-11-19 12:22:05'),
(2, 'Monster', 'HUNTER', '35 Rue du Palico', '77777', 'Seliana', '0123456789', 'Monster.Hunter@mon.co', '2020-11-19 12:35:01', '2021-05-09 11:15:27');

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

CREATE TABLE `commandes` (
  `id` int(10) UNSIGNED NOT NULL,
  `idCli` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `commercial`
--

CREATE TABLE `commercial` (
  `id` int(10) NOT NULL,
  `nomCom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenomCom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `adresseCom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `cpCom` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `villeCom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `emailCom` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `commercial`
--

INSERT INTO `commercial` (`id`, `nomCom`, `prenomCom`, `adresseCom`, `cpCom`, `villeCom`, `emailCom`, `email_verified_at`, `password`, `created_at`, `updated_at`) VALUES
(1, 'Chippy', 'James', '11 rue de Terraria', '14520', 'Angleterre', 'james.chippy@youtube.com', NULL, 'couch', NULL, '2021-05-09 10:57:29');

-- --------------------------------------------------------

--
-- Structure de la table `ligne_cdes`
--

CREATE TABLE `ligne_cdes` (
  `idCde` int(10) UNSIGNED NOT NULL,
  `idProd` int(10) UNSIGNED NOT NULL,
  `qte` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Contenu de la table `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(87, '2014_10_12_000000_create_users_table', 1),
(88, '2014_10_12_100000_create_password_resets_table', 1),
(89, '2020_11_09_150734_create_clients_table', 1),
(90, '2020_11_12_130612_create_rdvs_table', 1),
(91, '2020_11_12_130735_create_commandes_table', 1),
(92, '2020_11_12_130751_create_produits_table', 1),
(93, '2020_11_12_130801_create_lignecdes_table', 1),
(94, '2020_11_12_130811_create_prospects_table', 1);

-- --------------------------------------------------------

--
-- Structure de la table `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Contenu de la table `password_resets`
--

INSERT INTO `password_resets` (`email`, `token`, `created_at`) VALUES
('evan_lefevre@orange.fr', '$2y$10$fFHbo5UGS5q2b83tcDf2tOlUDkNrcPvwby.apPHjIjezDZnNk19Oy', '2020-12-02 11:29:47');

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE `produits` (
  `id` int(10) UNSIGNED NOT NULL,
  `libProd` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prixProd` decimal(7,2) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`id`, `libProd`, `prixProd`, `created_at`, `updated_at`) VALUES
(1, 'Croquettes de Cerbère', '6.66', '2020-11-12 16:05:48', '2020-11-12 16:05:51'),
(2, 'Vélo trou terrain', '510.00', '2020-12-09 11:26:37', '2020-12-09 11:26:37'),
(3, 'Red Luigi', '40.00', '2021-04-30 17:58:40', '2021-04-30 18:01:58'),
(8, 'Rajang', '20.25', '2021-05-09 11:13:34', '2021-05-09 11:13:39');

-- --------------------------------------------------------

--
-- Structure de la table `rdvs`
--

CREATE TABLE `rdvs` (
  `id` int(10) NOT NULL,
  `dateRdv` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `idCli` int(10) NOT NULL,
  `idCom` int(10) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `rdvs`
--

INSERT INTO `rdvs` (`id`, `dateRdv`, `idCli`, `idCom`, `created_at`, `updated_at`) VALUES
(1, '2021-05-08 22:00:00', 2, 1, '2021-05-08 19:39:08', '2021-05-09 09:13:20'),
(3, '2021-05-20 22:00:00', 1, 1, '2021-05-09 10:48:42', '2021-05-09 10:48:42');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `commandes`
--
ALTER TABLE `commandes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `commandes clients` (`idCli`);

--
-- Index pour la table `commercial`
--
ALTER TABLE `commercial`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `ligne_cdes`
--
ALTER TABLE `ligne_cdes`
  ADD PRIMARY KEY (`idCde`,`idProd`),
  ADD KEY `ligne_cdes_idprod_foreign` (`idProd`);

--
-- Index pour la table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `rdvs`
--
ALTER TABLE `rdvs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idCli` (`idCli`),
  ADD KEY `idPro` (`idCom`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `commandes`
--
ALTER TABLE `commandes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `commercial`
--
ALTER TABLE `commercial`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;
--
-- AUTO_INCREMENT pour la table `produits`
--
ALTER TABLE `produits`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `rdvs`
--
ALTER TABLE `rdvs`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `commandes`
--
ALTER TABLE `commandes`
  ADD CONSTRAINT `commandes clients` FOREIGN KEY (`idCli`) REFERENCES `clients` (`id`);

--
-- Contraintes pour la table `ligne_cdes`
--
ALTER TABLE `ligne_cdes`
  ADD CONSTRAINT `ligne cdes commandes` FOREIGN KEY (`idCde`) REFERENCES `commandes` (`id`),
  ADD CONSTRAINT `ligne_cdes_idprod_foreign` FOREIGN KEY (`idProd`) REFERENCES `produits` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
