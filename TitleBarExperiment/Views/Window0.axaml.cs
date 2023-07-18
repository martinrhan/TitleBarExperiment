using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Chrome;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace TitleBarExperiment.Views {
    public class Window0 : Window {
        public Window0() {
            ExtendClientAreaToDecorationsHint = true;
        }
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e) {
            base.OnApplyTemplate(e);
            var titleBar = this.FindDescendantOfType<TitleBar>();
            titleBar!.Background = new SolidColorBrush(Colors.LightBlue);
            titleBar.TemplateApplied += TitleBar_TemplateApplied;
            titleBar.PointerPressed += _PointerPressed;
        }

        private void TitleBar_TemplateApplied(object? sender, TemplateAppliedEventArgs e) {
            TitleBar? titleBar = sender as TitleBar;
            Control? background = e.NameScope.Find<Control>("PART_Background");
            background!.PointerPressed += _PointerPressed;
            Control? container = e.NameScope.Find<Control>("PART_Container");
            container!.PointerPressed += _PointerPressed;
            Control? mouseTracker = e.NameScope.Find<Control>("PART_MouseTracker");
            mouseTracker!.PointerPressed += _PointerPressed;
        }

        private void _PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e) {
        }
    }
}
