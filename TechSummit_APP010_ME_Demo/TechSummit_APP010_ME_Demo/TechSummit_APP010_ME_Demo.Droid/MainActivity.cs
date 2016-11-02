using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


////=====================================================
////②Webページは以下になっているがXamarin.Formsの場合は違う
////using Microsoft.Azure.Engagement;
////using Microsoft.Azure.Engagement.Activity;
////=====================================================
////using Microsoft.Azure.Engagement.Xamarin;


namespace TechSummit_APP010_ME_demo.Droid
{
    [Activity(Label = "TechSummit_APP010_ME_demo", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());


            ////=====================================================
            ////②Mobile Engagement バックエンドとの接続を初期化する
            ////ConnectionString は Azure Poral から取得して設定する
            ////=====================================================
            //EngagementConfiguration engagementConfiguration = new EngagementConfiguration();

            //engagementConfiguration.ConnectionString = "Mobile Engagement のキーを設定";
            //EngagementAgent.Init(engagementConfiguration);

        }



        ////=====================================================
        ////②ユーザーのアクティブ状態を送信する処理
        ////=====================================================

        //protected override void OnResume()
        //{
        //    EngagementAgent.StartActivity(EngagementAgentUtils.BuildEngagementActivityName(Java.Lang.Class.FromType(this.GetType())), null);
        //    base.OnResume();
        //}

        //protected override void OnPause()
        //{
        //    EngagementAgent.EndActivity();
        //    base.OnPause();
        //}

    }
}

