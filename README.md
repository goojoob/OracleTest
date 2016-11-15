# OracleTest
Super simple Visual C# application to test an Oracle Connection

This is a sample C# application developed in Visual Studio 2013.<br/>
Use this code to understand how integrate Oracle in your project.<br/><br/>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleTest.jpg)

## Prerequisites
Your project needs a reference to the dll containing the data provider.
<li>From Project menu, select Add Reference...</li>
<li>Scroll down the list of Component Names and select Oracle.DataAccess.</li>
<i>If you cant' find the Oracle.DataAccess reference, you need to install Oracle Data Access Components (ODAC) with Oracle Developer Tools for Visual Studio</i>
<br/>

![alt tag](http://goojoob.es/VARIOS/GitHub/OracleReference.jpg)<br/>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleReferencesProject.jpg)

## Using the Database class
This app change the label text to OK if all the parameters are correct and can stablish a connection with Oracle.<br/>
All you need to communicate with Oracle is in the <b>Database.cs</b> class:<br/>
<li>Database(String ip, String port, String service, String user, String pass)</li>
<i>Create a Database object and compose the dataSource string connection</i><br/><br/>
<li>oracleOpenConnection()</li>
<i>Connect to Oracle with the dataSource</i><br/><br/>
<li>oracleCloseConnection()</li>
<i>Disconnect from Oracle</i><br/><br/>
<li>executeSQL(String sql)</li>
<i>Execute a SQL command</i><br/><br/>

## Possible Errors
<li>Error connecting to the Oracle Host IP:</li>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleErrorConnectionIP.jpg)<br/><br/>
<li>Error listening to the Oracle Host Port:</li>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleErrorListeningPort.jpg)<br/><br/>
<li>Error listening to the Oracle Service:</li>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleErrorService.jpg)<br/><br/>
<li>Error with the Username or Password of the database scheme:</li>
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleErrorUserPass.jpg)<br/><br/>


## If everything is ok
![alt tag](http://goojoob.es/VARIOS/GitHub/OracleTestOK.jpg)<br/><br/>
