using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr12_4_Gurina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs e)
        {

        }

        private void count_Click(object sender, EventArgs e) // расчет суммы и общей калорийности
        {
            // Проверяем, выбрано ли пирожное в списке
            if (lstPirozhnoeInfo.SelectedItem == null)
            {
                MessageBox.Show("Выберите пирожное из списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранное пирожное
            Pirozhnoe selectedPirozhnoe = (Pirozhnoe)lstPirozhnoeInfo.SelectedItem;

            // Получаем количество от пользователя
            int kolvo = (int)kolichestvo.Value;

            // Рассчитываем стоимость и калорийность
            double totalCost = selectedPirozhnoe.PodschetStoimosti(kolvo);
            double totalCalories = selectedPirozhnoe.ObshchayaKalorinost() * kolvo;

            // Выводим результаты
            sum.Text = $"Стоимость: {totalCost} руб.";
            kalors.Text = $"Калорийность: {totalCalories} ккал";
        }
        private void DisplayPirozhnoeInfo(Pirozhnoe pirozhnoe)
        {
            //string info = $"Название: {pirozhnoe.Nazvanie}\n" +
            //              $"Тесто: {pirozhnoe.Testo}\n" +
            //              $"Крем: {pirozhnoe.Krem}\n" +
            //              $"Вес: {pirozhnoe.Ves} г\n" +
            //              $"Калорийность: {pirozhnoe.Kalorinost} ккал/100г\n" +
            //              $"Цена: {pirozhnoe.Tsena} руб.\n";

            lstPirozhnoeInfo.Items.Add(pirozhnoe);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Получаем данные от пользователя
            string nazvanie = Nazvanie.Text;
            string testo = Testo.Text;
            string krem = Krem.Text;
            double ves = (double)Ves.Value;
            double kalorinost = (double)Kalorinost.Value;
            double tsena = (double)Tsena.Value;

            // Создаем объект пирожного
            Pirozhnoe pirozhnoe = new Pirozhnoe(nazvanie, testo, krem, ves, kalorinost, tsena);

            // Отображаем информацию о пирожном
            DisplayPirozhnoeInfo(pirozhnoe);

            // Очищаем поля ввода
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            Nazvanie.Clear();
            Testo.Clear();
            Krem.Clear();
            Ves.Value = 0;
            Kalorinost.Value = 0;
            Tsena.Value = 0;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
