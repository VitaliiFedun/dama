using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Управление общими сведениями о сборке осуществляется с помощью 
// набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
// связанные со сборкой.
[assembly: AssemblyTitle("DAMA-DeAttach MAiler")]
[assembly: AssemblyDescription("Просто виконую чотири речі:\xD\xA"+
    "1.Шукаю в Microsoft Outlook листи з  вказаною темою (напр.-'DVR ALERT') у вказаному обліковому записі (напр.-'dvralert.xxxxxxxxx@gmail.com').\xD\xA "+
    "2.Листи без вкладень знищую.\xD\xA"+
    "3.Листи з вкладеннями переношу у підпапку DVR ALERT  папки 'Вхідні' Microsoft Outlook.\xD\xA"+
    "4.Вкладення копіюю у каталог на жорсткому диску(напр.-'H:\\Alert\\2017_05_01').")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Vitalii Fedun")]
[assembly: AssemblyProduct("DAMA-DeAttachMAiler")]
[assembly: AssemblyCopyright("Copyright © 2016-2018")]
[assembly: AssemblyTrademark("VF")]
[assembly: AssemblyCulture("")]

// Параметр ComVisible со значением FALSE делает типы в сборке невидимыми 
// для COM-компонентов.  Если требуется обратиться к типу в этой сборке через 
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("f3f77ec1-17e1-4921-8404-e0dc228e179a")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии 
//   Номер сборки
//      Редакция
//
// Можно задать все значения или принять номера сборки и редакции по умолчанию 
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
