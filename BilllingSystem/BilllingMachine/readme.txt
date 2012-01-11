Ниже небольшая инструкция по выполненному проекту:

1) Soluction 'BillingSystem' состоит из трех проектов:

	- BillingMachine 
	- BillingMachineWinService
	- BillingMachineWinServiceSetup

2) 'BillingMachine' - это основной проект (от него зависит 'BillingMachineWinService') с GUI (WinForm) и бизнес логикой.

Его можно просто билдить и запускать. 

GUI состоит из четырех табов:

	- General (общая информация: время, кол-во итераций, статус, процент завершенной работы, кол-во обработанных звонков)
	- Country (после нажатия на кнопку 'LoadCountry' загружаются данные из файла 'country.txt')
	- Rates (после нажатия на кнопку 'LoadRates' загружаются данные из файла 'rates.csv')
	- Calls (после нажатия на кнопку 'LoadCalls' открывает диалог для выбора одного из файлов 'calls1.txt', 'calls2.txt', 'calls3.txt'). 

NB! Файлы звонков обрабатываются по-одному.

В 'Resources' папке лежат все присланные исходные данные. Оттуда я выбирал файлы для обработки данных.
В класс '\Common\Globals.cs' вынесены все глобальные переменные, Lists и Dictionaries.

Количество итераций обработки данных можно поменять в этой переменной (по умолчанию 100. Это видно в GUI):

	- ITERATIONS_NUM_VALUE = 100;

NB! Если поменять значение количества итераций то шаг и максимальный размер в ProgressBar котроле автоматически изменятся на соответствующее значение.
Значение количества итераций в GUI также автоматически измениться.

Все пути к файлам из 'Resources' папке относительные и установлены в переменных:

	- ROOT_PROJECT_DIR
	- COUNTRY_FILE_NAME
	- RATES_FILE_NAME

Результаты можно посмотреть в файлах: 'output-calls1.txt', 'outuput-calls2.txt', 'output-calls3.txt'.
Пути к этим файлам находятся в следующих переменных с относительными путями:

	- OUTPUT_FILE_NAME
	- OUTPUT_RESOURCE_DIR


3) 'BillingMachineWinService' - это проект, реализованный в виде Windows Service. Он зависит от 'BillingMachine' проекта.
Этот проект нужно сбилдить и проинсталлировать Windows Service одним из двух способов:

	1. Запустить следующие комманды из коммандной строки (CMD). В моем случае:

	> installutil C:\Projects\CSC\BilllingSystem\BillingMachineWinService\bin\Debug\BillingMachineWinService.exe - инсталлировать сервис
	> installutil /u C:\Projects\CSC\BilllingSystem\BillingMachineWinService\bin\Debug\BillingMachineWinService.exe - деинсталлировать сервис

	2. См. пункт 4) ниже.

Затем запустить (Start/Stop) проинсталлированный 'BillingMachine' сервис из 'ControlPanel -> Administrative Tools -> Services'.

Количество итераций меняется также, т.е. из той же переменной, описанной выше (по умолчанию 100).

Все пути к файлам из 'Resources' папке абсолютные и установлены в переменных:

	- COUNTRY_ABSOLUTE_FILE_NAME
	- RATES_ABSOLUTE_FILE_NAME
	- CALLS_ABSOLUTE_DIR_NAME

NB! Их нужно поменять на свои.
Список файлов звонков находиться в списке (список менять не надо): public static List<string> LcallsFiles
В данном случае все три файла звонков ('calls1.txt', 'calls2.txt', 'calls3.txt') обрабатываются сразу при старте сервиса.

Результаты можно посмотреть в файлах: 'output-calls1.txt', 'outuput-calls2.txt', 'output-calls3.txt'.
Пути к этим файлам находятся в следующей переменной с относительными путями:

	- OUTPUT_ABSOLUTE_DIR_NAME

NB! Этот путь можно сменить на свой. Если не найдет, указанную директорию, то система сама создаст папку.


4) 'BillingMachineWinServiceSetup' - это проект, для установки по Wizard-у проекта 'BillingMachineWinService'.

Этот проект нужно сбилдить (вызывать из конекстного меню (right click на проекте) 'Build'/'Rebuild').
Для инсталляции нужно выбрать из контекстного меню 'Install'
Для деинсталляции нужно выбрать из контекстного меню 'Uninstall' или выбрать 'Uninstall' на 'BillingMachineWinServiceSetup' из 'ControlPanel -> Programs and Features'.
