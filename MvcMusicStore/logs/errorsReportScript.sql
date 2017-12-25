SELECT 
	Text AS Errors
INTO Report.csv
FROM 'D:\Work\Learning\epam\mentoringD1D2\solutions\Mentoring.2017.Module.11\Task\MvcMusicStore\logs\2017-12-25_summary.log'
WHERE Text LIKE '%ERROR%'