--------------------------------------------------------------------------------
  BUILDING IN RELEASE MODE
--------------------------------------------------------------------------------
    To build this project in Release mode either remove the post-build event 
    or install both 7-zip and NuGet and add their directories to Path.

--------------------------------------------------------------------------------
  RUNNING THE UNIT TEST SUITE
--------------------------------------------------------------------------------
    The unit test suite is currently configured to run using MS SQL Server.
    To run it on your computer change the connection string specified (hard-
    coded) in Setup/NHibernateConfigurer.cs to point to an empty database. 
    At "first run" the database will be constructed and necessary data will 
    be added to it.

--------------------------------------------------------------------------------
  TROUBLE-SHOOTING UNIT TEST SUITE 
--------------------------------------------------------------------------------
    If something goes wrong on a test run you might want to re-create the 
    database from scratch. To do this, delete the "nh.cfg" file from bin.