# CodeCamp2018
Source for 2FA Demo App

To run this app:

1.  Review the readme.txt included in the TwoFactor folder in the solution.  Follow these instructions to create the database tables and setup the connection string in the web.config.
2.  Follow the instructions here to obtain an API key for the Yubikey device you're using:  https://www.yubico.com/support/knowledge-base/categories/articles/get-api-key-yubikey-development/.  Note:  the device must be third generation (i.e. NEO) or greater as the basic security key won't work.  You'll also need to run the Personalization GUI and configure an empty slot on the device in order to get the OTP needed to obtain the API key.  More info on the Personalization GUI can be found here:  https://www.yubico.com/products/services-software/personalization-tools/use/.

Any missing NuGet packages can be restored via Tools > Options > NuGet Package Manager and selecting the option to "Allow NuGet to download missing package".  This solution is also designed to be run with Visual Studio 2017 and SQL Server.
