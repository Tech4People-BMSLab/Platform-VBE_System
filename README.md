# VBE_System
visual-biosensing-eyetracking platform.
starting with one system consisting of 7 Empatica E4, 1 360camera on a monopod, 1 Tobii Eye tracker 2, a laptop with a new VBE software APP.

Prerequisites:
1)Empatica BLE server is installed in your system.
2)Bluetooth BLED112 dongle 
*Refer: http://developer.empatica.com/windows-ble-server.html

The steps required:
1) Launch BLE Server
	Enter your API key
	Server address - loopback (127.0.0.1)
	Server Port - 28000
2) start the server and discover devices 
3) After all devices are visible in Empatica BLE Server - connect Windows Form application with Empatica BLE server using 'Connect' button.
4)Use 'Start all' to start data flow of all commands from all devices and 'Start' to start data for a particular command for an E4 id.
5)Once data flow is atrted you can start recording a session by pressing 'Record' and it will save data from all E4s at C:\Data\ in a folder named with session eposch time. This folder will have per E4 id named folders and store in csv format.


