using System;
using System.Drawing;
using System.Windows.Forms;

namespace with_webbrowser
{
    public partial class Main : Form {

        private String filePath;

        public Main() {
            InitializeComponent();

            this.openFileButton.Click += OpenFileButton_Click;
            this.closeDocButton.Click += CloseDocButton_Click;
            this.doItButton.Click += DoItButton_Click;
            this.aboutProgrammButton.Click += AboutProgrammButton_Click;
            this.exitButton.Click += ExitButton_Click;

            visibleComponents(false);
        }

        /// <summary>
        /// Метод открытия файла
        /// </summary>
        private void openFile() {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                filePath = fileDialog.FileName;

                webBrowser1.Navigate(new Uri(filePath));

                changeSize(900, 600);
                visibleComponents(true);
            }
        }

        /// <summary>
        /// Закрытие веб-сайта
        /// </summary>
        private void closeDoc() {
            webBrowser1.Url = null;

            changeSize(900, 520);
            visibleComponents(false);
        }

        /// <summary>
        /// Скрытие компонентов на форме
        /// </summary>
        /// <param name="what"></param>
        private void visibleComponents(bool what) {
            this.xTextBox.Visible = what;
            this.yTextBox.Visible = what;

            this.xPointLabel.Visible = what;
            this.yPointLabel.Visible = what;

            this.doItButton.Visible = what;
            this.closeDocButton.Visible = what;
        }

        /// <summary>
        /// Измнение размера окна
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void changeSize(int width, int height) {
            this.MinimumSize = new Size(width, height);
            this.MaximumSize = new Size(width, height);
            this.Size = new Size(width, height);
        }

        /// <summary>
        /// Метод расчета первого графика
        /// </summary>
        private void firstAlgorithm() {
            int x, y;
            // Координаты точки, вводимые пользователем
            try {
                x = Convert.ToInt32(xTextBox.Text);
                y = Convert.ToInt32(yTextBox.Text);
            } catch (FormatException) {
                MessageBox.Show("Ошибка вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                xTextBox.Text = "";
                yTextBox.Text = "";

                statusLabel.Text = "Статус расчета — ошибка вводимых данных";
                return;
            }

            if ((Math.Pow(x, 2) + Math.Pow(y, 2) == 1.0) ||
                ((x == -1 || x == 0) && (y == 1 || y == -1))) {
                MessageBox.Show("Точка лежит на границе!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if ((Math.Pow(x, 2) + Math.Pow(y, 2) < 1) ||
              ((x > -1 && x < 0) && (y < 1 && y > -1))) {
                MessageBox.Show("Точка принадлежит заштрихованной области!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Точка не принадлежит заштрихованной области!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            statusLabel.Text = "Статус расчета — успешно";
        }

        /// <summary>
        /// Метод расчета второго графика
        /// </summary>
        private void secondAlgorithm() {
            /** АЛГОРИТМ РАСЧЕТА **/

            int[] x = new int[4];
            int[] y = new int[4];

            // Координаты точки, вводимые пользователем
            try {
                x[0] = Convert.ToInt32(xTextBox.Text);
                y[0] = Convert.ToInt32(yTextBox.Text);
            } catch (FormatException) {
                MessageBox.Show("Ошибка вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                xTextBox.Text = "";
                yTextBox.Text = "";

                statusLabel.Text = "Статус расчета — ошибка вводимых данных";
                return;
            }

            // Координаты вершин треугольника (так как треугольник конкретный, то заполняются автоматически)
            x[1] = -5;
            y[1] = -3;
            x[2] = 1;
            y[2] = 4;
            x[3] = 5;
            y[3] = -4;

            int a = (x[1] - x[0]) * (y[2] - y[1]) - (x[2] - x[1]) * (y[1] - y[0]);
            int b = (x[2] - x[0]) * (y[3] - y[2]) - (x[3] - x[2]) * (y[2] - y[0]);
            int c = (x[3] - x[0]) * (y[1] - y[3]) - (x[1] - x[3]) * (y[3] - y[0]);

            if (a == 0 || b == 0 || c == 0) {
                MessageBox.Show("Точка лежит на границе!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0)) {
                MessageBox.Show("Точка принадлежит треугольнику!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Точка не принадлежит треугольнику!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            statusLabel.Text = "Статус расчета — успешно";
        }

        /// <summary>
        /// Обработка кнопка "Рассчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoItButton_Click(object sender, EventArgs e) {
            if (filePath.Contains("fpage.html")) {
                firstAlgorithm();
            } else if (filePath.Contains("spage.html")) {
                secondAlgorithm();
            } else {
                MessageBox.Show("Данная html-страница неизвестна программе!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Кнопка "Закрыть документ"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseDocButton_Click(object sender, EventArgs e) {
            closeDoc();
        }

        /// <summary>
        /// Кнопка "Открыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e) {
            openFile();
        }

        /// <summary>
        /// Кнопка "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Кнопка "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutProgrammButton_Click(object sender, EventArgs e) {
            MessageBox.Show("\tВариант №11\r\n\tАвтор программы — Ульянов А.В. ПКсп-117", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
