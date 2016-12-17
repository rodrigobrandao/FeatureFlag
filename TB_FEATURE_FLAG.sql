CREATE TABLE [dbo].[TB_FEATURE_FLAG]
(
    [Name] VARCHAR(40) NOT NULL PRIMARY KEY, 
    [State] VARCHAR(11) NOT NULL, 
    [StartDate] DATETIME NULL
)

INSERT INTO [dbo].[TB_FEATURE_FLAG] ([Name], [State], [StartDate]) VALUES (N'Feature01', N'Enabled', NULL)
INSERT INTO [dbo].[TB_FEATURE_FLAG] ([Name], [State], [StartDate]) VALUES (N'Feature02', N'Disabled', NULL)
INSERT INTO [dbo].[TB_FEATURE_FLAG] ([Name], [State], [StartDate]) VALUES (N'Feature03', N'Previewable', N'2016-12-17 01:05:00')
INSERT INTO [dbo].[TB_FEATURE_FLAG] ([Name], [State], [StartDate]) VALUES (N'Feature04', N'Enabled', NULL)
INSERT INTO [dbo].[TB_FEATURE_FLAG] ([Name], [State], [StartDate]) VALUES (N'Feature05', N'Disabled', NULL)