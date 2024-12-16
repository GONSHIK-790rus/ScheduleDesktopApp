using Guna.UI2.WinForms;

namespace ScheduleApp {
    internal class StylesAndAnimations {
        private static readonly Color _COMMON_COLOR = Color.FromArgb(40, 70, 220);
        public static void ErrorTextBoxFlashing(Guna2TextBox textBox) {
            int repeatCount = 5;
            var color = textBox.PlaceholderForeColor;

            for (int blueStep = 0; blueStep < repeatCount; blueStep++) {
                Task.Delay(75).Wait();
                SetColor(textBox, Color.Red);
                Task.Delay(75).Wait();
                SetColor(textBox, color);
            }
        }

        public static void SetCommonStyleForTextBox(Guna2TextBox textBox) {
            SetColor(textBox, _COMMON_COLOR);
        }

        public static void ErrorTextBox(Guna2TextBox textBox) {
            SetColor(textBox, Color.Red);
        }

        private static void SetColor(Guna2TextBox textBox, Color color) {
            textBox.BorderColor = color;
            textBox.PlaceholderForeColor = color;
        }
    }
}
