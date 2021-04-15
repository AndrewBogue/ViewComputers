To recreate the database from Computer.bak in this folder, please follow the steps outlined in https://sqlbackupandftp.com/blog/restore-database-backup under the section 'How to restore a database from backup using SQL Server Management Studio'

You will also need to update DefaultConnection in appsettings.json, after restoring the DB right click on the Computers database and in properties copy the Connection string.

It is assumed you have npm and Angular installed, if you do not please npm, then install Angular bu typing: npm install -g @angular/cli 
at the cmd prompt.
