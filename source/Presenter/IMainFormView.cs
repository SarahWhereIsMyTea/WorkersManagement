using System;

namespace Presenter
{
    interface IMainFormView
    {
        event EventHandler Load;
        event EventHandler Closed;

        MainFormViewModel ViewModel { get; set; }
    }
}
