-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 18 mai 2021 à 19:33
-- Version du serveur :  10.4.17-MariaDB
-- Version de PHP : 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `ppe-infotools`
--

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
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`id`, `prenomCli`, `nomCli`, `adresseCli`, `cpCli`, `villeCli`, `telCli`, `mailCli`, `created_at`, `updated_at`) VALUES
(1, 'Courage', 'Satan', 'Rue des flammes', '00110', 'En faire', '7894561230', 'Satan.Courage@Hell.to', '2020-11-16 13:26:47', '2020-11-19 12:22:05'),
(2, 'Monster', 'Hunter', '35 Rue du Palico', '77777', 'Seliana', '0123456789', 'Monster.Hunter@mon.co', '2020-11-19 12:35:01', '2020-11-19 12:35:01'),
(3, 'axa', 'axa', '26 route de menetou salon', '18110', 'bourges', '0606060606', 'test@test.fr', '2021-04-26 11:24:53', '2021-04-26 11:24:53');

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

--
-- Déchargement des données de la table `commandes`
--

INSERT INTO `commandes` (`id`, `idCli`, `created_at`, `updated_at`) VALUES
(1, 1, '2020-11-16 14:38:23', '2020-11-16 14:38:24');

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

--
-- Déchargement des données de la table `ligne_cdes`
--

INSERT INTO `ligne_cdes` (`idCde`, `idProd`, `qte`, `created_at`, `updated_at`) VALUES
(1, 1, 5, '2020-11-16 14:38:43', '2020-11-16 14:38:44');

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
-- Déchargement des données de la table `migrations`
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
-- Déchargement des données de la table `password_resets`
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
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`id`, `libProd`, `prixProd`, `created_at`, `updated_at`) VALUES
(1, 'Croquettes de Cerbère', '6.66', '2020-11-12 16:05:48', '2020-11-12 16:05:51'),
(2, 'Vélo trou terrain', '510.00', '2020-12-09 11:26:37', '2020-12-09 11:26:37');

-- --------------------------------------------------------

--
-- Structure de la table `prospects`
--

CREATE TABLE `prospects` (
  `id` int(10) UNSIGNED NOT NULL,
  `nomPros` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenomPros` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adressePros` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cpPros` varchar(5) COLLATE utf8mb4_unicode_ci NOT NULL,
  `villePros` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `idUser` bigint(20) UNSIGNED DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `prospects`
--

INSERT INTO `prospects` (`id`, `nomPros`, `prenomPros`, `adressePros`, `cpPros`, `villePros`, `idUser`, `created_at`, `updated_at`) VALUES
(1, 'Menvussa', 'Gerard', 'Rue de Diogene', '44444', 'Troy', 2, '2020-11-16 13:59:27', '2020-11-16 13:59:28'),
(2, 'bulber', 'dazd', 'adzadazd', '15520', 'dazadzazd', 6, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `rdvs`
--

CREATE TABLE `rdvs` (
  `id` int(10) UNSIGNED NOT NULL,
  `dateRdv` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `idCli` int(10) UNSIGNED NOT NULL,
  `idPro` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `rdvs`
--

INSERT INTO `rdvs` (`id`, `dateRdv`, `idCli`, `idPro`, `created_at`, `updated_at`) VALUES
(2, '2020-12-25 13:18:00', 2, 1, '2020-12-09 12:16:33', '2020-12-09 12:16:33'),
(3, '2021-04-30 19:17:00', 3, 1, '2021-04-26 12:13:28', '2021-04-26 12:13:28'),
(5, '2021-05-06 21:18:00', 2, 2, '2021-05-18 15:14:36', '2021-05-18 15:14:36');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_admin` tinyint(4) DEFAULT 0,
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `email_verified_at`, `password`, `is_admin`, `remember_token`, `created_at`, `updated_at`) VALUES
(2, 'AAAAAAAH', 'evan_lefevre@orange.fr', NULL, '$2y$10$9bs5AzMBHljKlhnkrYFQiOSGR9ZBAqSd7HfUDmmmMiJuZ9LR5MfvW', 0, 'v6ClhjHy8ND1TLSVpYxHdBHMIDUjMqNvkSvteEQMK6DthJtXdAEqO1iUdP6b', '2020-12-02 11:40:57', '2020-12-02 11:40:57'),
(5, 'Axa', 'alexa.for25452@gmail.com', NULL, '$2y$10$D73nM5g5UdRAg9dRwcQ/2.4lZWJW7wOpzljmAdzNNUXi..0xju8m6', 0, NULL, '2021-03-31 09:54:41', '2021-03-31 09:54:41'),
(6, 'ptdr', 'ptdr@ptdr.cpt', NULL, '$2y$10$3FyMXPd5tpk4mCshipbo/.AYaY2AyraJKmW43ur3WQ8N0npio6DkW', 0, NULL, '2021-05-18 12:08:01', '2021-05-18 12:08:01');

--
-- Index pour les tables déchargées
--

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
-- Index pour la table `prospects`
--
ALTER TABLE `prospects`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkUser` (`idUser`);

--
-- Index pour la table `rdvs`
--
ALTER TABLE `rdvs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `rdvs clients` (`idCli`),
  ADD KEY `rdvs prospects` (`idPro`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `commandes`
--
ALTER TABLE `commandes`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;

--
-- AUTO_INCREMENT pour la table `produits`
--
ALTER TABLE `produits`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `prospects`
--
ALTER TABLE `prospects`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `rdvs`
--
ALTER TABLE `rdvs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Contraintes pour les tables déchargées
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

--
-- Contraintes pour la table `prospects`
--
ALTER TABLE `prospects`
  ADD CONSTRAINT `fkUser` FOREIGN KEY (`idUser`) REFERENCES `users` (`id`);

--
-- Contraintes pour la table `rdvs`
--
ALTER TABLE `rdvs`
  ADD CONSTRAINT `rdvs clients` FOREIGN KEY (`idCli`) REFERENCES `clients` (`id`),
  ADD CONSTRAINT `rdvs prospects` FOREIGN KEY (`idPro`) REFERENCES `prospects` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
