﻿using System.Windows.Input;
using TailwindTraders.Mobile.Features.LogIn;
using TailwindTraders.Mobile.Features.Product.Category;
using TailwindTraders.Mobile.Features.Scanning.AR;
using TailwindTraders.Mobile.Features.Scanning.Photo;
using TailwindTraders.Mobile.Framework;

namespace TailwindTraders.Mobile.Features.Shell
{
    internal class TheShellViewModel : BaseViewModel
    {
        public ICommand PhotoCommand => new AsyncCommand(
            _ => App.NavigateModallyToAsync(new CameraPreviewTakePhotoPage(), animated: false));

        public ICommand ARCommand => new AsyncCommand(
            _ => App.NavigateToAsync(new CameraPreviewPage(), closeFlyout: true));

        public ICommand LogOutCommand => new AsyncCommand(_ => App.NavigateModallyToAsync(new LogInPage()));

        public ICommand ProductTypeCommand => new AsyncCommand(
            typeId => App.NavigateToAsync(new ProductCategoryPage(typeId as string), closeFlyout: true));

        public ICommand ProfileCommand => FeatureNotAvailableCommand;
    }
}