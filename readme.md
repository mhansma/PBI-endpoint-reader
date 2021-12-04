I've created this project for an easy way to get the Power BI localhost connection. As describe at http://biinsight.com/connect-to-power-bi-desktop-model-from-excel-and-ssms/, Power BI is running an instance of SQL Server Analysis Services in the back. 
After installing this application, you can directly get the connection string. This can be used to connect to your localhost Power BI dataset with tools like Excel or SQL Server Management Studio.
1. Build the project
1. Change the path in the file endpoint-reader.pbitool.json. The path needs to point to your exe.
1. Copy endpoint-reader.pbitool.json to "C:\Program Files (x86)\Common Files\Microsoft Shared\Power BI Desktop\External Tools"
1. After restarting Power BI Desktop, the tool should be availble under te "External tools". Click on th button and a small window opens with the connectionstring settings.
