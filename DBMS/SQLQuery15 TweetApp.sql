/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[AuthorName]
      ,[AuthorLogo]
      ,[AuthorSlug]
      ,[TweetTime]
      ,[TweetDescription]
      ,[TweetImage]
  FROM [TweetDB].[dbo].[TblTweet]where AuthorName like '%j%'