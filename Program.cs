﻿//Использование пространства имён:
using System.Windows.Forms;

//Класс с главным методом программы:
class DialogDemo
{
    //Главный метод программы
    static void Main()
    {
        //Отображение диалогового окна:
            MessageBox.Show("Продолжаем изучать C#", //Сообщение
            "Третья программа", //Название окна
            MessageBoxButtons.OKCancel, //Кнопки
            MessageBoxIcon.Asterisk); //Пиктограмма
    }
}
