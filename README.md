
# BakeYard GPS - backyardgps
#### A VB.Net application using COM Port and radio interface

[Wiki - App Webpage](http://mezcel.wixsite.com/backyardgps), this webpage explains the background behind developing this DIY application.

* Visual Studio Project
    * BakeYard GPS\BakeYard GPS.sln


* Requires a BU-353 Gps Receiver (USB Antenna)
    * pl2303hxa_windows_8_driver_installation\PL2303_Prolific_DriverInstaller_v1.5.0.exe

___Note:___ During development, I used the ["XAML Regions"](https://visualstudiogallery.msdn.microsoft.com/3c534623-bb05-417f-afc0-c9e26bf0e177) plugin to help me keep track of my code. It is a small extension that adds the ability to define collapsible regions in XAML & XML code.

# About:

#### Latitude/Longitude Coordinates via GPS Radio Signal

This application is developed in VB/NET

* This App uses a serial COM port peripheral interface to receive inputs from a USB GPS antenna.
* GPS radio signal messages are translated into ASCII/Char string sentence format.
* Various forms of timing and scheduling  are used to capture recorded and real-time data to end user.
* For the App Developer, this is a handy Skeleton Code-like kit.

#### What to expect from this Application:

* Input GPS Radio Signal Location Information via a GPS antenna
* Select from a list of USB ports to receive your GPS antenna
* Reliable location calculations within 1sec intervals
* View real time present location latitude and longitude
* View recent list of way-points reflecting where the end user last logged his/her present location
* Save way-point in a time stamped text file
* View a X-Y coordinate plane which shows a relative scale relationship to how far a person has moved from their start location
