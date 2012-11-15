using Cirrious.MvvmCross.Binding.Interfaces;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Dialog.Touch.AutoView.ExtensionMethods;
using Cirrious.MvvmCross.Dialog.Touch.AutoView.Interfaces;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Views.Attributes;
using Foobar.Dialog.Core.Menus;

namespace Cirrious.MvvmCross.Dialog.Touch.AutoView.Views.Lists
{
    [MvxUnconventionalView]
    public class MvxAutoListActivityView
        : MvxBindingTouchTableViewController<MvxViewModel>
        , IMvxTouchAutoView<MvxViewModel>
    {
        private IParentMenu _parentMenu;
        private GeneralListLayout _list;

        protected MvxAutoListActivityView(MvxShowViewModelRequest request) : base(request)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _list = this.LoadList();
            var source = _list.InitialiseSource(TableView);
#warning TODO - RegisterBindingsFor - Which binding is released where? This is confusing me?
            //RegisterBindingsFor(source);
            /*
            _parentMenu = this.LoadMenu();

            
            _list = this.LoadList();
            var listView = _list.InitialiseListView(this);
            this.SetContentView(listView);
            RegisterBindingsFor(listView);
            */
        }

        public void RegisterBinding(IMvxUpdateableBinding binding)
        {
            Bindings.Add(binding);
        }

        /*
#warning consider making static - and moving to extension method?
        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            return this.CreateOptionsMenu(_parentMenu, menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (_parentMenu.ProcessMenuItemSelected(item))
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
         */
    }
}