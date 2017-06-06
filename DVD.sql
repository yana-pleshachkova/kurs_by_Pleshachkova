-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 06 2017 г., 20:54
-- Версия сервера: 10.0.28-MariaDB
-- Версия PHP: 5.6.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `DVD`
--

-- --------------------------------------------------------

--
-- Структура таблицы `abonements`
--

CREATE TABLE `abonements` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `deleted_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `countries`
--

CREATE TABLE `countries` (
  `id` int(11) NOT NULL,
  `sortname` varchar(3) NOT NULL,
  `name` varchar(150) NOT NULL,
  `phonecode` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `countries`
--

INSERT INTO `countries` (`id`, `sortname`, `name`, `phonecode`) VALUES
(1, 'AF', 'Afghanistan', 93),
(2, 'AL', 'Albania', 355),
(3, 'DZ', 'Algeria', 213),
(4, 'AS', 'American Samoa', 1684),
(5, 'AD', 'Andorra', 376),
(6, 'AO', 'Angola', 244),
(7, 'AI', 'Anguilla', 1264),
(8, 'AQ', 'Antarctica', 0),
(9, 'AG', 'Antigua And Barbuda', 1268),
(10, 'AR', 'Argentina', 54),
(11, 'AM', 'Armenia', 374),
(12, 'AW', 'Aruba', 297),
(13, 'AU', 'Australia', 61),
(14, 'AT', 'Austria', 43),
(15, 'AZ', 'Azerbaijan', 994),
(16, 'BS', 'Bahamas The', 1242),
(17, 'BH', 'Bahrain', 973),
(18, 'BD', 'Bangladesh', 880),
(19, 'BB', 'Barbados', 1246),
(20, 'BY', 'Belarus', 375),
(21, 'BE', 'Belgium', 32),
(22, 'BZ', 'Belize', 501),
(23, 'BJ', 'Benin', 229),
(24, 'BM', 'Bermuda', 1441),
(25, 'BT', 'Bhutan', 975),
(26, 'BO', 'Bolivia', 591),
(27, 'BA', 'Bosnia and Herzegovina', 387),
(28, 'BW', 'Botswana', 267),
(29, 'BV', 'Bouvet Island', 0),
(30, 'BR', 'Brazil', 55),
(31, 'IO', 'British Indian Ocean Territory', 246),
(32, 'BN', 'Brunei', 673),
(33, 'BG', 'Bulgaria', 359),
(34, 'BF', 'Burkina Faso', 226),
(35, 'BI', 'Burundi', 257),
(36, 'KH', 'Cambodia', 855),
(37, 'CM', 'Cameroon', 237),
(38, 'CA', 'Canada', 1),
(39, 'CV', 'Cape Verde', 238),
(40, 'KY', 'Cayman Islands', 1345),
(41, 'CF', 'Central African Republic', 236),
(42, 'TD', 'Chad', 235),
(43, 'CL', 'Chile', 56),
(44, 'CN', 'China', 86),
(45, 'CX', 'Christmas Island', 61),
(46, 'CC', 'Cocos (Keeling) Islands', 672),
(47, 'CO', 'Colombia', 57),
(48, 'KM', 'Comoros', 269),
(49, 'CG', 'Congo', 242),
(50, 'CD', 'Congo The Democratic Republic Of The', 242),
(51, 'CK', 'Cook Islands', 682),
(52, 'CR', 'Costa Rica', 506),
(53, 'CI', 'Cote D\'Ivoire (Ivory Coast)', 225),
(54, 'HR', 'Croatia (Hrvatska)', 385),
(55, 'CU', 'Cuba', 53),
(56, 'CY', 'Cyprus', 357),
(57, 'CZ', 'Czech Republic', 420),
(58, 'DK', 'Denmark', 45),
(59, 'DJ', 'Djibouti', 253),
(60, 'DM', 'Dominica', 1767),
(61, 'DO', 'Dominican Republic', 1809),
(62, 'TP', 'East Timor', 670),
(63, 'EC', 'Ecuador', 593),
(64, 'EG', 'Egypt', 20),
(65, 'SV', 'El Salvador', 503),
(66, 'GQ', 'Equatorial Guinea', 240),
(67, 'ER', 'Eritrea', 291),
(68, 'EE', 'Estonia', 372),
(69, 'ET', 'Ethiopia', 251),
(70, 'XA', 'External Territories of Australia', 61),
(71, 'FK', 'Falkland Islands', 500),
(72, 'FO', 'Faroe Islands', 298),
(73, 'FJ', 'Fiji Islands', 679),
(74, 'FI', 'Finland', 358),
(75, 'FR', 'France', 33),
(76, 'GF', 'French Guiana', 594),
(77, 'PF', 'French Polynesia', 689),
(78, 'TF', 'French Southern Territories', 0),
(79, 'GA', 'Gabon', 241),
(80, 'GM', 'Gambia The', 220),
(81, 'GE', 'Georgia', 995),
(82, 'DE', 'Germany', 49),
(83, 'GH', 'Ghana', 233),
(84, 'GI', 'Gibraltar', 350),
(85, 'GR', 'Greece', 30),
(86, 'GL', 'Greenland', 299),
(87, 'GD', 'Grenada', 1473),
(88, 'GP', 'Guadeloupe', 590),
(89, 'GU', 'Guam', 1671),
(90, 'GT', 'Guatemala', 502),
(91, 'XU', 'Guernsey and Alderney', 44),
(92, 'GN', 'Guinea', 224),
(93, 'GW', 'Guinea-Bissau', 245),
(94, 'GY', 'Guyana', 592),
(95, 'HT', 'Haiti', 509),
(96, 'HM', 'Heard and McDonald Islands', 0),
(97, 'HN', 'Honduras', 504),
(98, 'HK', 'Hong Kong S.A.R.', 852),
(99, 'HU', 'Hungary', 36),
(100, 'IS', 'Iceland', 354),
(101, 'IN', 'India', 91),
(102, 'ID', 'Indonesia', 62),
(103, 'IR', 'Iran', 98),
(104, 'IQ', 'Iraq', 964),
(105, 'IE', 'Ireland', 353),
(106, 'IL', 'Israel', 972),
(107, 'IT', 'Italy', 39),
(108, 'JM', 'Jamaica', 1876),
(109, 'JP', 'Japan', 81),
(110, 'XJ', 'Jersey', 44),
(111, 'JO', 'Jordan', 962),
(112, 'KZ', 'Kazakhstan', 7),
(113, 'KE', 'Kenya', 254),
(114, 'KI', 'Kiribati', 686),
(115, 'KP', 'Korea North', 850),
(116, 'KR', 'Korea South', 82),
(117, 'KW', 'Kuwait', 965),
(118, 'KG', 'Kyrgyzstan', 996),
(119, 'LA', 'Laos', 856),
(120, 'LV', 'Latvia', 371),
(121, 'LB', 'Lebanon', 961),
(122, 'LS', 'Lesotho', 266),
(123, 'LR', 'Liberia', 231),
(124, 'LY', 'Libya', 218),
(125, 'LI', 'Liechtenstein', 423),
(126, 'LT', 'Lithuania', 370),
(127, 'LU', 'Luxembourg', 352),
(128, 'MO', 'Macau S.A.R.', 853),
(129, 'MK', 'Macedonia', 389),
(130, 'MG', 'Madagascar', 261),
(131, 'MW', 'Malawi', 265),
(132, 'MY', 'Malaysia', 60),
(133, 'MV', 'Maldives', 960),
(134, 'ML', 'Mali', 223),
(135, 'MT', 'Malta', 356),
(136, 'XM', 'Man (Isle of)', 44),
(137, 'MH', 'Marshall Islands', 692),
(138, 'MQ', 'Martinique', 596),
(139, 'MR', 'Mauritania', 222),
(140, 'MU', 'Mauritius', 230),
(141, 'YT', 'Mayotte', 269),
(142, 'MX', 'Mexico', 52),
(143, 'FM', 'Micronesia', 691),
(144, 'MD', 'Moldova', 373),
(145, 'MC', 'Monaco', 377),
(146, 'MN', 'Mongolia', 976),
(147, 'MS', 'Montserrat', 1664),
(148, 'MA', 'Morocco', 212),
(149, 'MZ', 'Mozambique', 258),
(150, 'MM', 'Myanmar', 95),
(151, 'NA', 'Namibia', 264),
(152, 'NR', 'Nauru', 674),
(153, 'NP', 'Nepal', 977),
(154, 'AN', 'Netherlands Antilles', 599),
(155, 'NL', 'Netherlands The', 31),
(156, 'NC', 'New Caledonia', 687),
(157, 'NZ', 'New Zealand', 64),
(158, 'NI', 'Nicaragua', 505),
(159, 'NE', 'Niger', 227),
(160, 'NG', 'Nigeria', 234),
(161, 'NU', 'Niue', 683),
(162, 'NF', 'Norfolk Island', 672),
(163, 'MP', 'Northern Mariana Islands', 1670),
(164, 'NO', 'Norway', 47),
(165, 'OM', 'Oman', 968),
(166, 'PK', 'Pakistan', 92),
(167, 'PW', 'Palau', 680),
(168, 'PS', 'Palestinian Territory Occupied', 970),
(169, 'PA', 'Panama', 507),
(170, 'PG', 'Papua new Guinea', 675),
(171, 'PY', 'Paraguay', 595),
(172, 'PE', 'Peru', 51),
(173, 'PH', 'Philippines', 63),
(174, 'PN', 'Pitcairn Island', 0),
(175, 'PL', 'Poland', 48),
(176, 'PT', 'Portugal', 351),
(177, 'PR', 'Puerto Rico', 1787),
(178, 'QA', 'Qatar', 974),
(179, 'RE', 'Reunion', 262),
(180, 'RO', 'Romania', 40),
(181, 'RU', 'Russia', 70),
(182, 'RW', 'Rwanda', 250),
(183, 'SH', 'Saint Helena', 290),
(184, 'KN', 'Saint Kitts And Nevis', 1869),
(185, 'LC', 'Saint Lucia', 1758),
(186, 'PM', 'Saint Pierre and Miquelon', 508),
(187, 'VC', 'Saint Vincent And The Grenadines', 1784),
(188, 'WS', 'Samoa', 684),
(189, 'SM', 'San Marino', 378),
(190, 'ST', 'Sao Tome and Principe', 239),
(191, 'SA', 'Saudi Arabia', 966),
(192, 'SN', 'Senegal', 221),
(193, 'RS', 'Serbia', 381),
(194, 'SC', 'Seychelles', 248),
(195, 'SL', 'Sierra Leone', 232),
(196, 'SG', 'Singapore', 65),
(197, 'SK', 'Slovakia', 421),
(198, 'SI', 'Slovenia', 386),
(199, 'XG', 'Smaller Territories of the UK', 44),
(200, 'SB', 'Solomon Islands', 677),
(201, 'SO', 'Somalia', 252),
(202, 'ZA', 'South Africa', 27),
(203, 'GS', 'South Georgia', 0),
(204, 'SS', 'South Sudan', 211),
(205, 'ES', 'Spain', 34),
(206, 'LK', 'Sri Lanka', 94),
(207, 'SD', 'Sudan', 249),
(208, 'SR', 'Suriname', 597),
(209, 'SJ', 'Svalbard And Jan Mayen Islands', 47),
(210, 'SZ', 'Swaziland', 268),
(211, 'SE', 'Sweden', 46),
(212, 'CH', 'Switzerland', 41),
(213, 'SY', 'Syria', 963),
(214, 'TW', 'Taiwan', 886),
(215, 'TJ', 'Tajikistan', 992),
(216, 'TZ', 'Tanzania', 255),
(217, 'TH', 'Thailand', 66),
(218, 'TG', 'Togo', 228),
(219, 'TK', 'Tokelau', 690),
(220, 'TO', 'Tonga', 676),
(221, 'TT', 'Trinidad And Tobago', 1868),
(222, 'TN', 'Tunisia', 216),
(223, 'TR', 'Turkey', 90),
(224, 'TM', 'Turkmenistan', 7370),
(225, 'TC', 'Turks And Caicos Islands', 1649),
(226, 'TV', 'Tuvalu', 688),
(227, 'UG', 'Uganda', 256),
(228, 'UA', 'Ukraine', 380),
(229, 'AE', 'United Arab Emirates', 971),
(230, 'GB', 'United Kingdom', 44),
(231, 'US', 'United States', 1),
(232, 'UM', 'United States Minor Outlying Islands', 1),
(233, 'UY', 'Uruguay', 598),
(234, 'UZ', 'Uzbekistan', 998),
(235, 'VU', 'Vanuatu', 678),
(236, 'VA', 'Vatican City State (Holy See)', 39),
(237, 'VE', 'Venezuela', 58),
(238, 'VN', 'Vietnam', 84),
(239, 'VG', 'Virgin Islands (British)', 1284),
(240, 'VI', 'Virgin Islands (US)', 1340),
(241, 'WF', 'Wallis And Futuna Islands', 681),
(242, 'EH', 'Western Sahara', 212),
(243, 'YE', 'Yemen', 967),
(244, 'YU', 'Yugoslavia', 38),
(245, 'ZM', 'Zambia', 260),
(246, 'ZW', 'Zimbabwe', 263);

-- --------------------------------------------------------

--
-- Структура таблицы `disks`
--

CREATE TABLE `disks` (
  `id` int(11) NOT NULL,
  `title` varchar(56) NOT NULL,
  `about` text NOT NULL,
  `year` timestamp NULL DEFAULT NULL,
  `actors` text NOT NULL,
  `directed_by` varchar(256) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `cost` float NOT NULL,
  `count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `disks`
--

INSERT INTO `disks` (`id`, `title`, `about`, `year`, `actors`, `directed_by`, `created_at`, `deleted_at`, `updated_at`, `cost`, `count`) VALUES
(1, 'Пираты Карибского моря: Мертвецы не рассказывают сказки', 'Исчерпавший свою удачу капитан Джек Воробей обнаруживает, что за ним охотится его старый неприятель, ужасный капитан Салазар и его призрачные пираты. Они только что сбежали из Дьявольского треугольника и намерены уничтожить всех пиратов, включая Джека. Поможет спастись лишь могущественный артефакт — трезубец Посейдона, который дарует своему обладателю полный контроль над морями.', '1994-06-14 19:00:00', 'Джонни Депп,\nХавьер Бардем,\nДжеффри Раш,\nБрентон Туэйтс,\nКая Скоделарио,\nКевин МакНэлли,\nГолшифте Фарахани,\nДэвид Уэнэм,\nСтивен Грэм,\nЭнгус Барнетт,', 'Хоаким Роннинг, Эспен Сандберг', '2017-04-30 19:00:00', NULL, '2017-05-29 06:55:37', 250, 100),
(2, 'Меч короля Артура', 'Молодой Артур живёт на задворках Лондиниума вместе со своей бандой. Он и понятия не имел о своём королевском происхождении, пока однажды не взял в руки меч Эскалибур. Меч начинает менять Артура. В результате он присоединяется к сопротивлению и таинственной молодой девушке по имени Гвиневра. Ему предстоит научиться понимать магическое оружие, которым он овладел, столкнуться со своими собственными демонами и объединить народ в борьбе против диктатора Вортигерна, убившего его родителей и завладевшего короной.', '2017-05-14 19:00:00', 'Чарли Ханнэм,\r\nАстрид Берже-Фрисби,\r\nДжуд Лоу,\r\nДжимон Хонсу,\r\nЭрик Бана,\r\nЭйдан Гиллен,\r\nФредди Фокс,\r\nКрэйг МакГинли,\r\nТом Ву,\r\nКингсли Бен-Адир,', 'Гай Ричи', '2017-05-08 19:00:00', NULL, '2017-05-29 06:55:37', 230, 11),
(3, 'TEST', 'TEST', '2017-05-29 18:48:30', 'TEST', 'TEST', '2017-05-29 18:48:55', NULL, '2017-05-29 18:48:55', 233.23, 34),
(4, 'QWERTY', 'QWERTY', '2017-05-29 18:51:37', 'QWERTY', 'QWERTY', '2017-05-29 18:52:08', NULL, '2017-05-29 18:52:08', 34.33, 123),
(5, 'SDF1', 'SDF1', '2017-05-29 18:53:16', 'SDF', 'SDF', '2017-05-29 18:53:39', NULL, '2017-05-29 18:53:39', 23.23, 23);

-- --------------------------------------------------------

--
-- Структура таблицы `disks_countries`
--

CREATE TABLE `disks_countries` (
  `id_disk` int(11) NOT NULL,
  `id_country` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `disks_countries`
--

INSERT INTO `disks_countries` (`id_disk`, `id_country`) VALUES
(2, 3),
(2, 6),
(0, 4),
(0, 5),
(0, 8),
(3, 2),
(3, 5),
(3, 6),
(5, 9),
(5, 13),
(5, 16),
(1, 1),
(1, 2),
(1, 15);

-- --------------------------------------------------------

--
-- Структура таблицы `disks_genres`
--

CREATE TABLE `disks_genres` (
  `disk_id` int(11) NOT NULL,
  `genre_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `disks_genres`
--

INSERT INTO `disks_genres` (`disk_id`, `genre_id`) VALUES
(2, 4),
(2, 5),
(0, 3),
(0, 6),
(0, 9),
(0, 15),
(0, 14),
(0, 11),
(3, 5),
(3, 8),
(3, 12),
(3, 11),
(3, 6),
(3, 14),
(5, 4),
(5, 6),
(5, 7),
(5, 11),
(5, 14),
(1, 1),
(1, 6),
(1, 5),
(1, 8),
(1, 14);

-- --------------------------------------------------------

--
-- Структура таблицы `genres`
--

CREATE TABLE `genres` (
  `id` int(11) NOT NULL,
  `title` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `genres`
--

INSERT INTO `genres` (`id`, `title`) VALUES
(1, 'Аниме'),
(2, 'Биографический'),
(3, 'Боевик'),
(4, 'Вестерн'),
(5, 'Военный'),
(6, 'Детектив'),
(7, 'Детский'),
(8, 'Драма'),
(9, 'Документальный'),
(10, 'Научный'),
(11, 'Приключения'),
(12, 'Комедия'),
(13, 'Фантастика'),
(14, 'Спорт'),
(15, 'Сериал');

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `abonement_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `manager_id` int(11) NOT NULL,
  `finished` timestamp NULL DEFAULT NULL,
  `expire` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `cost` float NOT NULL,
  `count_disks` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `orders_disks`
--

CREATE TABLE `orders_disks` (
  `order_id` int(11) NOT NULL,
  `disk_id` int(11) NOT NULL,
  `finished` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `orders_returned`
--

CREATE TABLE `orders_returned` (
  `id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `return_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `count_disks` int(11) NOT NULL,
  `corrupted_disks` int(11) NOT NULL,
  `fine` float NOT NULL COMMENT 'Штраф',
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `orders_trashs`
--

CREATE TABLE `orders_trashs` (
  `tmp_order_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `disk_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `name` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `roles`
--

INSERT INTO `roles` (`id`, `name`) VALUES
(1, 'Admin'),
(2, 'Manager'),
(3, 'Customer');

-- --------------------------------------------------------

--
-- Структура таблицы `shift`
--

CREATE TABLE `shift` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `open_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `close_date` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Смена';

-- --------------------------------------------------------

--
-- Структура таблицы `tokens`
--

CREATE TABLE `tokens` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `token` varchar(32) NOT NULL,
  `expires` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tokens`
--

INSERT INTO `tokens` (`id`, `user_id`, `token`, `expires`, `created_at`) VALUES
(1, 3, '95acf64e-c386-43c5-b6c9-bfce5020', '2017-05-29 04:43:31', '2017-05-29 04:43:31'),
(2, 3, '4f966489-cdec-4b06-8e30-1430cc8f', '2017-05-29 04:44:48', '2017-05-29 04:44:48'),
(3, 3, 'f455b914-5048-4478-810b-7bbd1e97', '2017-05-29 04:46:06', '2017-05-29 04:46:06'),
(4, 3, '79cb57fe-8ec7-426e-a10c-d4828b7a', '2017-05-29 04:46:45', '2017-05-29 04:46:45'),
(5, 3, '57000108-2c98-4625-916d-de4d426e', '2017-05-29 04:47:02', '2017-05-29 04:47:02'),
(6, 3, 'c8d8bea1-d5d5-4a4d-9126-7ec5c530', '2017-05-29 04:48:23', '2017-05-29 04:48:23'),
(7, 3, '3190fe3f-d7e7-4ca4-94fe-e425422c', '2017-05-29 04:49:52', '2017-05-29 04:49:52'),
(8, 2, '1f050530-6c82-40bf-b3a3-e9693265', '2017-05-29 04:52:36', '2017-05-29 04:52:36'),
(9, 2, '9bca8fd0-eab1-42f4-b06d-33f1d2b1', '2017-05-29 04:54:20', '2017-05-29 04:54:20'),
(10, 2, 'a27ceb77-47b3-42e1-9bd1-56cb82ee', '2017-05-29 04:59:43', '2017-05-29 04:59:43'),
(11, 2, 'e5226e17-adb1-4083-ad3e-1fb71afc', '2017-05-29 05:00:23', '2017-05-29 05:00:23'),
(12, 2, 'b755bda0-255f-4281-8d7c-bad1f2ee', '2017-05-29 05:01:46', '2017-05-29 05:01:46'),
(13, 1, 'ea724952-8be1-41ab-a9d9-1581fd42', '2017-05-29 05:02:25', '2017-05-29 05:02:25'),
(14, 1, '7b6a2306-d634-4b45-bba3-1a0bb259', '2017-05-29 05:15:52', '2017-05-29 05:15:52'),
(15, 1, '209389a1-9e26-4731-bc7c-21609555', '2017-05-29 05:19:17', '2017-05-29 05:19:17'),
(16, 1, 'e5b6a0f6-92b4-49eb-9484-717df04e', '2017-05-29 05:21:11', '2017-05-29 05:21:11'),
(17, 1, '460eea70-c0a6-4812-bb70-5599fab0', '2017-05-29 05:23:10', '2017-05-29 05:23:10'),
(18, 1, '6577f789-cb75-4ee4-9ee1-c0c15ab1', '2017-05-29 05:25:29', '2017-05-29 05:25:29'),
(19, 1, '33026b08-e588-4a8e-b383-02f6d993', '2017-05-29 05:27:54', '2017-05-29 05:27:54'),
(20, 1, 'f05b83bd-6e36-4da9-be75-2d81e65f', '2017-05-29 05:28:26', '2017-05-29 05:28:26'),
(21, 1, 'dc037ad9-61f0-4085-af3e-0de27282', '2017-05-29 05:29:05', '2017-05-29 05:29:05'),
(22, 1, 'ec32dc62-396f-4754-970b-d4578202', '2017-05-29 05:33:18', '2017-05-29 05:33:18'),
(23, 1, '178f8d1e-ef03-401e-b859-a2047722', '2017-05-29 05:33:57', '2017-05-29 05:33:57'),
(24, 1, '1067d915-c22f-4547-91b6-b43374e2', '2017-05-29 05:47:59', '2017-05-29 05:47:59'),
(25, 1, 'a9c534f5-a2c7-4d54-8e8d-3d5e4f35', '2017-05-29 05:48:54', '2017-05-29 05:48:54'),
(26, 1, '82e120b8-5a3c-4a31-b38c-941487d2', '2017-05-29 05:50:53', '2017-05-29 05:50:53'),
(27, 1, 'db9c2f94-984b-407f-b945-b839f320', '2017-05-29 05:54:26', '2017-05-29 05:54:26'),
(28, 1, '87246d7a-e289-4d89-ac8f-ee31b161', '2017-05-29 05:54:52', '2017-05-29 05:54:52'),
(29, 1, '17ef1a37-c940-422b-b44d-faea32d4', '2017-05-29 05:58:13', '2017-05-29 05:58:13'),
(30, 1, '6a0fe883-4ff6-4efe-8c54-7720b507', '2017-05-29 06:22:38', '2017-05-29 06:22:38'),
(31, 1, '4db3f5da-7db3-4958-aa8a-d310b242', '2017-05-29 06:23:33', '2017-05-29 06:23:33'),
(32, 1, '439ce029-30dd-47d4-b6c5-2c03c589', '2017-05-29 06:24:37', '2017-05-29 06:24:37'),
(33, 1, '566f8913-70df-4d91-9030-39aafdf2', '2017-05-29 06:25:32', '2017-05-29 06:25:32'),
(34, 1, 'ec8153eb-817a-4e85-ae03-4c599b3e', '2017-05-29 06:27:23', '2017-05-29 06:27:23'),
(35, 1, '068e7bce-4641-47c4-93ab-d15c8fd2', '2017-05-29 06:35:54', '2017-05-29 06:35:54'),
(36, 4, 'a7cc2bd4-9b2c-4807-bd58-fcb8c349', '2017-05-29 06:36:38', '2017-05-29 06:36:38'),
(37, 1, '333786f7-4d55-4774-8f13-7de5344f', '2017-05-29 06:39:57', '2017-05-29 06:39:57'),
(38, 2, '30c0d4a3-102b-4339-bf3b-b44d9731', '2017-05-29 06:40:09', '2017-05-29 06:40:09'),
(39, 1, '557266f2-2a18-4cc3-8061-b059a5dd', '2017-05-29 06:40:19', '2017-05-29 06:40:19'),
(40, 2, 'fed82a11-83e3-4bab-9ab5-4a945b13', '2017-05-29 06:40:39', '2017-05-29 06:40:39'),
(41, 1, '2f44f552-9436-4a38-accb-e6d55c28', '2017-05-29 07:12:47', '2017-05-29 07:12:47'),
(42, 1, '57a0f7cc-a3a9-4f11-8d4e-c5ef4f08', '2017-05-29 07:13:04', '2017-05-29 07:13:04'),
(43, 1, 'fc8222bb-29c3-4406-bfdb-8750d1e0', '2017-05-29 07:13:43', '2017-05-29 07:13:43'),
(44, 1, 'b2891a51-d29a-40a2-ba7c-64a2ef76', '2017-05-29 07:14:34', '2017-05-29 07:14:34'),
(45, 1, 'd098892f-d2ac-400f-8af8-c2aabf80', '2017-05-29 07:24:24', '2017-05-29 07:24:24'),
(46, 1, 'cb3323e5-29a1-4122-919c-187b0432', '2017-05-29 07:25:11', '2017-05-29 07:25:11'),
(47, 1, 'd3be408e-a894-47ad-b4f6-f45d080d', '2017-05-29 07:25:23', '2017-05-29 07:25:23'),
(48, 1, '52cab07d-c9a0-4d75-aca9-c4d59c7d', '2017-05-29 07:25:43', '2017-05-29 07:25:43'),
(49, 1, 'debb3751-5284-4274-812b-9df505b4', '2017-05-29 07:25:59', '2017-05-29 07:25:59'),
(50, 1, '491f3f06-78a7-46e9-9738-1c151e48', '2017-05-29 07:26:33', '2017-05-29 07:26:33'),
(51, 1, '54dfea28-444a-4f1f-bc4d-b47d32b0', '2017-05-29 07:27:00', '2017-05-29 07:27:00'),
(52, 1, 'bf122b5c-e899-497b-be72-de699a8e', '2017-05-29 07:35:35', '2017-05-29 07:35:35'),
(53, 1, '64ecb5c0-1d6f-4168-b401-0971df81', '2017-05-29 07:35:58', '2017-05-29 07:35:58'),
(54, 1, 'f6dde2a2-e3b8-4007-9b51-37d45bf6', '2017-05-29 07:54:18', '2017-05-29 07:54:18'),
(55, 1, '4a172b2f-16d9-4be6-a007-b63197e3', '2017-05-29 07:56:07', '2017-05-29 07:56:07'),
(56, 1, '4d475bc8-3dc6-4192-b68b-b9672d92', '2017-05-29 07:56:51', '2017-05-29 07:56:51'),
(57, 1, '0590b61a-13ad-4f86-8959-6b76c777', '2017-05-29 07:58:40', '2017-05-29 07:58:40'),
(58, 1, 'ec33c7c7-6369-4601-9c43-02825807', '2017-05-29 08:01:13', '2017-05-29 08:01:13'),
(59, 1, 'd4af3d5f-930f-4aee-948d-145b919f', '2017-05-29 15:33:41', '2017-05-29 15:33:41'),
(60, 1, 'ac05dcf8-5f30-4e36-a980-1de129f5', '2017-05-29 16:06:24', '2017-05-29 16:06:24'),
(61, 1, '1f0ff960-58cf-4998-ac3a-a4019e8a', '2017-05-29 16:15:06', '2017-05-29 16:15:06'),
(62, 1, 'b2bbd557-1590-4319-946e-755c3287', '2017-05-29 16:55:13', '2017-05-29 16:55:13'),
(63, 1, 'b5283dc6-bed8-4e09-8464-efdbea0f', '2017-05-29 16:55:41', '2017-05-29 16:55:41'),
(64, 1, 'd87d7895-af90-4111-8110-644f06f4', '2017-05-29 16:57:04', '2017-05-29 16:57:04'),
(65, 1, '24cd0da1-9728-4450-a49d-b1069521', '2017-05-29 17:05:38', '2017-05-29 17:05:38'),
(66, 1, 'b4a72d7d-d2e1-4307-a2da-04143567', '2017-05-29 17:13:46', '2017-05-29 17:13:46'),
(67, 1, '8efc3b51-5f62-4375-9a11-17b5119b', '2017-05-29 17:14:32', '2017-05-29 17:14:32'),
(68, 1, '6d43fbe0-9501-466d-bc7a-5747395e', '2017-05-29 17:15:24', '2017-05-29 17:15:24'),
(69, 1, '94f51d10-bbe6-4f83-9dcb-daf93439', '2017-05-29 17:17:20', '2017-05-29 17:17:20'),
(70, 1, '7a2b7a68-45e0-4a66-92a5-2c1a0097', '2017-05-29 17:19:22', '2017-05-29 17:19:22'),
(71, 1, '3ce8d706-4084-462a-a400-8da12cda', '2017-05-29 17:20:02', '2017-05-29 17:20:02'),
(72, 1, 'ae67fb69-1968-4d5f-9e51-a4059b8e', '2017-05-29 17:21:47', '2017-05-29 17:21:47'),
(73, 1, '00e635f2-0997-4f00-84ab-403aed74', '2017-05-29 17:24:37', '2017-05-29 17:24:37'),
(74, 1, 'cbf7bca3-f488-4186-8b0b-b30b38d0', '2017-05-29 17:25:16', '2017-05-29 17:25:16'),
(75, 1, 'ac0c3af6-486f-4422-b8f2-b90e9538', '2017-05-29 17:27:09', '2017-05-29 17:27:09'),
(76, 1, 'a5c96274-af4a-4fa8-8436-50af6122', '2017-05-29 17:28:01', '2017-05-29 17:28:01'),
(77, 1, '19979e3b-7faa-4aa8-9375-a542d603', '2017-05-29 18:09:38', '2017-05-29 18:09:38'),
(78, 1, '8e0cfbe8-fd37-4398-976f-17c213e5', '2017-05-29 18:11:09', '2017-05-29 18:11:09'),
(79, 1, '368bf820-ccf4-4cc5-a9a7-fbd12b07', '2017-05-29 18:11:57', '2017-05-29 18:11:57'),
(80, 1, '61b4179e-4297-4b79-a6b0-48da6af2', '2017-05-29 18:12:31', '2017-05-29 18:12:31'),
(81, 1, '07da7746-a257-412f-a6e6-475506c6', '2017-05-29 18:13:42', '2017-05-29 18:13:42'),
(82, 1, 'e060eac8-69c4-4a24-bd68-0400f2bc', '2017-05-29 18:15:39', '2017-05-29 18:15:39'),
(83, 1, 'f7ecd4c0-a264-4fbc-9574-fa7a4b1a', '2017-05-29 18:16:13', '2017-05-29 18:16:13'),
(84, 1, '3480ca05-8659-4a2a-8305-385c4b8c', '2017-05-29 18:17:23', '2017-05-29 18:17:23'),
(85, 1, 'ad28a494-009c-4617-a7cd-ef868352', '2017-05-29 18:19:05', '2017-05-29 18:19:05'),
(86, 1, '2e6f06e7-0739-4b61-ab72-d8178e5b', '2017-05-29 18:19:46', '2017-05-29 18:19:46'),
(87, 1, '45db95b0-ddb5-41ce-ba1a-5c7e4711', '2017-05-29 18:21:29', '2017-05-29 18:21:29'),
(88, 1, 'd675c5a6-fbd3-43e4-9398-8f4954ad', '2017-05-29 18:24:27', '2017-05-29 18:24:27'),
(89, 1, 'a1a99cb6-6623-4098-ba58-ac39a5be', '2017-05-29 18:25:01', '2017-05-29 18:25:01'),
(90, 1, 'ab1f2e2d-64a5-4300-ad30-b7172ef2', '2017-05-29 18:25:46', '2017-05-29 18:25:46'),
(91, 1, 'dbdf6abd-8792-4e17-ac00-93b6e029', '2017-05-29 18:29:28', '2017-05-29 18:29:28'),
(92, 1, 'cfccc966-171e-4f27-8c46-db5e0890', '2017-05-29 18:29:45', '2017-05-29 18:29:45'),
(93, 1, '3989aa11-5f34-4781-90f1-ad7047a4', '2017-05-29 18:31:48', '2017-05-29 18:31:48'),
(94, 1, '95ef4b98-d422-42d0-9062-950e8895', '2017-05-29 18:32:37', '2017-05-29 18:32:37'),
(95, 1, '40fa97c6-6929-43af-8996-d0c75288', '2017-05-29 18:34:25', '2017-05-29 18:34:25'),
(96, 1, 'ce3d4a63-1638-4d58-9a67-e23ef9a3', '2017-05-29 18:36:54', '2017-05-29 18:36:54'),
(97, 1, '52cab6a7-81b3-4066-936e-21c135f5', '2017-05-29 18:40:57', '2017-05-29 18:40:57'),
(98, 1, 'a4485998-10c1-40d3-a91c-36334405', '2017-05-29 18:48:27', '2017-05-29 18:48:27'),
(99, 1, '1300cbd2-009d-4050-9df7-53d731ac', '2017-05-29 18:51:16', '2017-05-29 18:51:16'),
(100, 1, 'bd19aacb-abc2-449d-8dab-c7197278', '2017-05-29 18:53:13', '2017-05-29 18:53:13'),
(101, 1, '80482718-cf24-4581-b586-098f7336', '2017-05-29 18:54:49', '2017-05-29 18:54:49'),
(102, 1, 'efb71014-2d06-4e52-b77a-53143490', '2017-05-29 18:58:05', '2017-05-29 18:58:05'),
(103, 1, '02c458d9-81f8-411c-a9be-9d770261', '2017-05-29 19:00:16', '2017-05-29 19:00:16'),
(104, 3, 'f611c342-876f-4597-8ea9-495e3ec4', '2017-05-30 16:50:41', '2017-05-30 16:50:41'),
(105, 2, 'dd57907f-6bdf-4342-862a-9634a447', '2017-05-30 16:50:54', '2017-05-30 16:50:54'),
(106, 1, '05f2e7ab-5add-4668-8335-ba9f5ac5', '2017-05-30 16:51:42', '2017-05-30 16:51:42'),
(107, 3, 'e2387989-299f-4cae-a182-248c4dab', '2017-05-30 16:54:05', '2017-05-30 16:54:05'),
(108, 2, '6b19f513-c904-4b6b-9968-cc8811c7', '2017-05-30 16:54:34', '2017-05-30 16:54:34'),
(109, 1, '0b1b453e-8e0e-482a-883d-7e1c341b', '2017-06-01 17:13:45', '2017-06-01 17:13:45');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL COMMENT 'Идентификатор пользователя',
  `first_name` varchar(56) NOT NULL COMMENT 'Имя',
  `last_name` varchar(56) NOT NULL COMMENT 'Фамилия',
  `patronumyc` varchar(56) NOT NULL COMMENT 'Отчество',
  `phones` varchar(255) NOT NULL COMMENT 'Телефонs',
  `birth_date` timestamp NULL DEFAULT NULL,
  `passport_number` int(10) NOT NULL COMMENT 'Номер паспорта',
  `passport_year` timestamp NULL DEFAULT NULL COMMENT 'Год выдачи',
  `passport_issuer` varchar(255) NOT NULL COMMENT 'Кем выдан',
  `created_at` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `deleted_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `login` varchar(32) NOT NULL,
  `password_hash` varchar(64) NOT NULL,
  `email` varchar(56) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Пользователи';

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `first_name`, `last_name`, `patronumyc`, `phones`, `birth_date`, `passport_number`, `passport_year`, `passport_issuer`, `created_at`, `deleted_at`, `updated_at`, `login`, `password_hash`, `email`, `role`) VALUES
(1, 'Масяня1', 'Иванов1', 'Олегович', '12345678,98765432,325523', '2017-04-30 19:00:00', 1234564567, '2010-01-26 19:00:00', 'ГУП', '2017-05-27 10:35:10', NULL, '2017-05-30 16:52:10', 'admin', 'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', 'admin@admin.admin', 1),
(2, 'Менеджер', 'Самый', 'Лучший', '12345678,98765432,325523', '2017-03-06 19:00:00', 1234564567, '2016-07-04 19:00:00', 'Чел', '2017-05-27 10:35:10', NULL, '2017-05-29 06:40:30', 'manager', '65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5', 'manager@manager.manager', 2),
(3, 'Клиент', 'Самый', 'Лучший', '12345678,98765432,325523', '2017-03-06 19:00:00', 1234564567, '2015-09-07 19:00:00', 'МСК', '2017-05-27 10:35:10', NULL, '2017-05-29 05:58:05', 'client', '65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5', 'client@client.client', 3),
(4, 'admin1', 'admin1', 'admin1', '098,765', '2004-06-17 06:35:56', 213, '2017-05-29 06:35:56', 'RTY', '2017-05-29 06:36:27', NULL, '2017-05-29 08:01:56', 'admin1', '65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5', 'admin1@admin1.admin1', 1),
(5, '2@2.2', '2@2.2', '2@2.2', '222', '2017-05-29 18:35:59', 123, '2017-05-29 18:35:59', '123', '2017-05-29 18:36:27', NULL, '2017-05-29 18:36:27', '2', 'dbc6e5113e2659acbbd1dc7ff20346c2e461ff80c3bb419bee89dd44c599444c', '2@2.2', 2);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `abonements`
--
ALTER TABLE `abonements`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `countries`
--
ALTER TABLE `countries`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `disks`
--
ALTER TABLE `disks`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `orders_returned`
--
ALTER TABLE `orders_returned`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `shift`
--
ALTER TABLE `shift`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tokens`
--
ALTER TABLE `tokens`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `abonements`
--
ALTER TABLE `abonements`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT для таблицы `countries`
--
ALTER TABLE `countries`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=247;
--
-- AUTO_INCREMENT для таблицы `disks`
--
ALTER TABLE `disks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT для таблицы `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT для таблицы `orders_returned`
--
ALTER TABLE `orders_returned`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT для таблицы `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT для таблицы `shift`
--
ALTER TABLE `shift`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT для таблицы `tokens`
--
ALTER TABLE `tokens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;
--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Идентификатор пользователя', AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
