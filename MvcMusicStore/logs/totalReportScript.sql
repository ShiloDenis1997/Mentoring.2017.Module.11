SELECT 
	TRIM(SUBSTR(text, 25, 5)) AS [Log_levels], 
	COUNT([Index]) AS [Total_Count]
INTO Report.csv
FROM 'D:\Work\Learning\epam\mentoringD1D2\solutions\Mentoring.2017.Module.11\Task\MvcMusicStore\logs\2017-12-25_summary.log' 
GROUP BY TRIM(SUBSTR(text, 25, 5))
