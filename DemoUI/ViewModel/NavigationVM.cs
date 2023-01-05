﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUI.Utilities;
using System.Windows.Input;
using DemoUI.Model;

namespace DemoUI.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;

        private Dictionary<string, object> prototype_view;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }


        //For basic data binding in the playback bars
        public string currentMediaName { get; set; }
        public string currentSinger { get; set; }
        public string currentUri { get; set; }
        public string mediaDuration { get; set; }


        public ICommand HomeCommand { get; set; }
        public ICommand MusicLibraryCommand { get; set; }
        public ICommand VideoLibraryCommand { get; set; }
        public ICommand PlaylistCommand { get; set; }
        public ICommand PlayingCommand { get; set; }

        private void Home(object obj) => CurrentView = prototype_view["Home"];
        private void MusicLibrary(object obj) => CurrentView = prototype_view["MusicLibrary"];
        private void VideoLibrary(object obj) => CurrentView = prototype_view["VideoLibrary"];
        private void Playlist(object obj) => CurrentView = prototype_view["Playlist"];
        private void Playing(object obj) => CurrentView = prototype_view["UserControl"];
        public NavigationVM()
        {

            prototype_view = new Dictionary<string, object>();

            prototype_view.Add("Home", new HomeVM());
            prototype_view.Add("MusicLibrary", new MusicLibraryVM(this));
            prototype_view.Add("Playlist", new PlaylistVM());
            prototype_view.Add("VideoLibrary", new VideoLibraryVM(this));
            prototype_view.Add("UserControl", new UserControlVM());
            


            //Inject event here
            VideoLibraryVM videoLibraryVM = (VideoLibraryVM)prototype_view["VideoLibrary"];
            videoLibraryVM.passToNavigation += setInfoFromMedia;
            videoLibraryVM.navigateToPlayer += navigateToMediaPlayer;

            MusicLibraryVM musicLibraryVM = (MusicLibraryVM)prototype_view["MusicLibrary"];
            musicLibraryVM.passToNavigationMusic += setInfoFromMedia;
            musicLibraryVM.navigateToPlayer += navigateToMediaPlayer;

            HomeCommand = new RelayCommand(Home);
            MusicLibraryCommand = new RelayCommand(MusicLibrary);
            VideoLibraryCommand = new RelayCommand(VideoLibrary);
            PlaylistCommand = new RelayCommand(Playlist);
            PlayingCommand = new RelayCommand(Playing);
            // Startup Page
            CurrentView = prototype_view["Home"];
        }

        public void setInfoFromMedia(Media media)
        {
            this.currentMediaName = media.name;
            if (media.getType() == "Music")
            {
                this.currentSinger = ((Music)media).Singer;
            }
            else
            {
                this.currentSinger = null;
            }
            this.mediaDuration = media.duration;
            this.currentUri = media.uri;
        }

       

        public void navigateToMediaPlayer()
        {
            UserControlVM userControl = (UserControlVM)prototype_view["UserControl"];
            userControl.setData(currentMediaName, mediaDuration, currentUri);
            CurrentView = userControl;

        }


    }
}
