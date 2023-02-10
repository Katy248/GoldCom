using System.Windows.Input;

namespace GoldCom.Commands;
public class CommandBase : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public virtual bool CanExecute(object? parameter) => true;

    public virtual void Execute(object? parameter) { }
}
