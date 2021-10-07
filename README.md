# User Manual
## Installation:
1) Follow the link: https://github.com/Ziggchik/HotDesk
2) Press green button "Code"
3) In the drop-down list that opens, select how you want to install the project
### Download Zip:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Download Zip"
3) The "download" folder will contain the downloaded archive, unzip it to any place on your computer
4) In Unzip files open  "HotDesk.sln"
6) Save open project (Ctrl+Shift+S) in any place on you computer
7) Press buttons combination "Shift+F5" to launch application
### Open with Visual Stido:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Open with Visual Studio"
3) In Visual Studio click to button "Clone repository"
4) Solution will donwload from repository and you can save project (Ctrl+Shift+S) in any place on you computer
### Download with command:
1) Press button combination "Win+R" and write "cmd"
2) Write this commands:
* git clonehttps://github.com/Ziggchik/HotDesk.git
* cd HotDesk
* dotnet build
* dotnet run
3) After that application will start
## How to use:
### Admin
1) Run application
2) Authorize wth your login/email and password 
3) In navigation panel you can choose the function you need for administration 
#### Administrator functions (Manage Workplaces)
1) Click on label "Менеджер рабочих мест" in navigation panel
2) In the window that opens, you can see a table with information about already registered workplaces
3) If you need delete workplace click button "Удалить" opposite the workplace that you want to delete
4) If you need add new workplace click button "Добавить рабочее место"
5) In the popup menu that opens, write in textbox description and choose the status of having a PC on the workplace
6) If you want close menu click button "Закрыть", If you filled description and status of having a PC on the workplace and want create workplace click button "Добавить"
7) After that new information will be added in table
#### Administrator functions (Manage Devices)
1) Click on label "Менеджер устройств" in navigation panel
2) In the window that opens, you can see a table with information about already registered devices
3) If you need delete device click button "Удалить" opposite the devise that you want to delete
4) If you need add new device click button "Добавить рабочее место"
5) In the popup menu that opens, write in textbox device name
6) If you want close menu click button "Закрыть", If you filled device name and want create device click button "Добавить"
7) After that new information will be added in table
#### Administrator functions (Manage Reservations)
1) Click on label "Менеджер бронирований" in navigation panel
2) In the window that opens, you can see a table with information about reserved workplaces and devices
3) If you need delete device click button "Удалить" opposite the devise that you want to delete
4) If you need change information click "Изменить информацию о бронировании"
5) In the popup menu that opens, you can add or remove additional devices on reserved workpalse
6) Choose devices and click button "Обновить информацию"
7) After that new information will be added in table
#### Administrator functions (Logout)
1) If you want leave site click on label "Выйти" in navigation panel (up-right corner) 
2) After that you will be rederict in authorization window
### User(Employee)
1) Run application
2) Authorize wth your login/email and password 
3) In navigation panel you can choose avaliable workpalces and view your workplaces
#### User functions (Registration)
1) If you new user in system you need to register
2) Click on label "Регистрация"
3) In the window that opens fill login/Email, password and confirm password fields
4) If login is unique you will be successful registered and you can use your login and password for authorization in system
#### User functions (Avaliable workplaces)
1) Click on label "Свободные места" in navigation panel
2) Choose the date which you want to book a workplace and click button "Поиск мест"
3) After that you will see table with avaliable workplaces on selected date
4) Click button "Забронировать место" opposite the workplase that you want to book
5) After that you will see confirmation window with information about workplace and availiavle additional divices
6) If you need additional divices select the necessary items from the provided list and click button "Подтвердить"
#### User functions (My reservations)
1) Click on label "Мои забронированные места" in navigation panel
2) After that you will see table with information about the workplaces you have booked.
#### User functions (Logout)
1) If you want leave site click on label "Выйти" in navigation panel (up-right corner) 
2) After that you will be rederict in authorization window
## Architecture: 
1) The project create with ASP.NET Core 3.1 MVC and using language C#.
2) The project uses Microsoft.EntityFrameworkCore 5.0.10
3) The project uses addons for Microsoft.EntityFrameworkCore (Tools, Proxies, SqlServer, Design)
4) Database create on SqlServer and use query language T-sql
## Application Updates:
In the near future in application new features will be added to the application:
1) Class with new unit-tests
2) Update and Filter functions
3) Users function to cancel booking workplace
4) Self-registration will be added to admin and remove from user to avoid the appearance of false information
5) New design
