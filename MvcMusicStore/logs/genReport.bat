.\LogParser.exe -i "TEXTLINE" file:totalReportScript.sql -o "CSV" -filemode 1 -headers ON
.\LogParser.exe -i "TEXTLINE" file:errorsReportScript.sql -o "CSV" -filemode 0 -headers ON