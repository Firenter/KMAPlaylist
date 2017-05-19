USE KMA
GO

Create Table dbo.Song(
	ID int identity Primary Key,
	Title varchar(300),
	ExampleURL varchar(500) null
)

Create Table dbo.Playlist(
	ID int identity Primary Key,
	[Name] varchar(300)
)

Create Table dbo.PlaylistSong(
	ID int identity Primary Key,
	Playlist int References dbo.Playlist(ID),
	Song int References dbo.Song(ID)
)

Create Table dbo.MetadataType(
	ID int identity Primary Key,
	[Name] varchar(300)
)

Create Table dbo.MetaData(
	ID int identity Primary Key,
	Song int null References dbo.Song(ID),
	MetaParent int null References dbo.MetaData(ID),
	[Type] int References dbo.MetadataType(ID),
	[Data] varchar(300)
)