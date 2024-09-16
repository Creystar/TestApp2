//Использование пространства имён:
using System.Windows.Forms;

//Класс с главным методом программы:
class DialogDemo
{
    //Главный метод программы
    static void Main()
    {
        //Отображение диалогового окна:
        MessageBox.Show("Продолжаем изучать C#",
            "Третья программа",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Asterisk);
    }
}
