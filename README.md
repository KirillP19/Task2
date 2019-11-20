# Тестовое Задание 2

Таблицы:

dbo.status – справочник статусов 

CREATE TABLE [dbo].[status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

dbo.post – справочник должностей 

CREATE TABLE [dbo].[posts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

dbo.deps – справочник отделов 
CREATE TABLE [dbo].[deps](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_deps] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

dbo.persons – журнал сотрудников (ФИО, дата приема и дата увольнения (могут быть не заполнены), статус, отдел и должность)
CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[second_name] [varchar](100) NOT NULL,
	[last_name] [varchar](100) NOT NULL,
	[date_employ] [datetime] NULL,
	[date_uneploy] [datetime] NULL,
	[status] [int] NOT NULL,
	[id_dep] [int] NOT NULL,
	[id_post] [int] NOT NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
 
Написать программу-клиент для просмотра следующих данных: списки сотрудников, статистическая информация по спискам сотрудников в днях.

Предусмотреть возможность ввода строки соединения с сервером в программе (настроечный файл).

1.	Выводить в списке сотрудников следующие данные: ФИО (в формате Фамилия И. О.), наименование статуса, наименование отдела, наименование должности, даты приема и увольнения если есть. Предусмотреть возможность сортировки списка по любому из полей. Предусмотреть фильтрацию списка по статусу, отделу, должности и части фамилии (по вхождению заданной строки в фамилию).
2.	Выводить следующую статистику по списку сотрудников: количество сотрудников выбранного статуса, принятых или уволенных на работу за заданный период с разбиением по дням. Для этого предусмотреть в программе возможность выбора статуса из списка имеющихся в базе статусов, указание периода за который необходимо выводить статистику, переключение вывода статистики по принятым на работу и уволенным сотрудникам.

Обращение к таблицам выполнять через хранимые процедуры. Предусмотреть в программе все необходимые проверки корректности ввода данных.

Задание может быть выполнено частично.
