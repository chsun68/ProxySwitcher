# Proxy Switcher

**Proxy Switcher** is a tiny program that let you switch on/off the windows IE proxy by single mouse click. 
It is very useful if you have to use a notebook in the workplace and at home. 
You can quickly turn on the proxy for the workplace network and turn off it for your home network.

## How to use

**Proxy Switcher** can be run manually or automatically by putting the executable file in your Startup folder.
Then it stays in the notification area of your task bar and shows the proxy on/off status. 

* A left-click on its icon will toggle the proxy on/off immediately. 
* A right-clck on its icon will prompt the context menu.
* A double-click on the icon will prompt the proxy configuration window.

## Installation

Installation of **Proxy Switcher** is easy: drag the execution file into your startup folder, and that is it.

Here is the detail steps of the installation:

1. Press WIN-R to open the Run command window.
2. Type @shellstartup@ in the Run command windows and click OK. This will open your Startup folder in the windows resource explorer.
3. Drag the executable file into the Startup folder.
4. Double-click the executable file or re-login the windows. You will find *Http Proxy Switcher* in the notification area


## License

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published 
by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.


## Acknowledgements

This program uses [*RegistryMonitor*](https://www.codeproject.com/articles/4502/registrymonitor-a-net-wrapper-class-for-regnotifyc) to 
monitor the windows registry change event that Microsoft WQL cannot do, 
which is created by [Thomas Freudenberg](https://www.codeproject.com/script/Membership/View.aspx?mid=4960) 
under [The Code Project Open Liense (CPOL)](http://www.codeproject.com/info/cpol10.aspx). 
