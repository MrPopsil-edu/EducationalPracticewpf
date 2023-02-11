using System;
using System.Windows;

namespace EducationalPracticeWpf.Class
{
    public static class Helper
    {
        public static EducationalPracticeWpfEntities BD;
        public static Users userActive = new Users();
        static Helper()
        {
            try
            {
                BD = new EducationalPracticeWpfEntities();
                if (BD.Database.Exists() == false)
                {
                    MessageBox.Show("БД не найдена!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    BD = null;
                }
            }
            catch
            {
                MessageBox.Show("Не найдена BD", "Ошибка открытия BD", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }
    }
}