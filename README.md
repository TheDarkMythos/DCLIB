# DCLIB
 Шаблон DCLIB плагина для DCRat.

Этот шаблон содержит класс [`DCLIBHelper.cs`](https://github.com/boldenis44/DCLIB/blob/master/DCLIBHelper.cs "`DCLIBHelper.cs`"), используйте его для получения конфига для вашего плагина. Простое чтение данных из файла может вызвать проблемы с совместимостью плагина.

Получение конфига:

    string PluginConfig = DCLIB.GetConfigFile("MyConfigFile.cfg");

Он ишет файл **рядом с билдом** или **в ресурсах билда**.
