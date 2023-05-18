﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RJ1_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RJ1_demoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("51a05f38-b411-4604-9add-4d41699b24bc")]
    public partial class RJ1_demoRepository : RepoGenBaseFolder
    {
        static RJ1_demoRepository instance = new RJ1_demoRepository();
        RJ1_demoRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the RJ1_demoRepository element repository.
        /// </summary>
        [RepositoryFolder("51a05f38-b411-4604-9add-4d41699b24bc")]
        public static RJ1_demoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RJ1_demoRepository() 
            : base("RJ1_demoRepository", "/", null, 0, false, "51a05f38-b411-4604-9add-4d41699b24bc", ".\\RepositoryImages\\RJ1_demoRepository51a05f38.rximgres")
        {
            _rxmainframe = new RJ1_demoRepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("51a05f38-b411-4604-9add-4d41699b24bc")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("692e1790-8f4e-49c9-9d3f-e8d64e7fd364")]
        public virtual RJ1_demoRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class RJ1_demoRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("692e1790-8f4e-49c9-9d3f-e8d64e7fd364")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@title>'Ranorex Studio Demo Appli']", parentFolder, 30000, null, true, "692e1790-8f4e-49c9-9d3f-e8d64e7fd364", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@index='0' and @controlname='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "a807e97a-4ed4-4b66-9ec7-864d001c1b22");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@index='0' and @controlname='RxTabIntroduction']/button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "44a1bcec-366e-4942-9099-c77add612475");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("692e1790-8f4e-49c9-9d3f-e8d64e7fd364")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("692e1790-8f4e-49c9-9d3f-e8d64e7fd364")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("a807e97a-4ed4-4b66-9ec7-864d001c1b22")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("a807e97a-4ed4-4b66-9ec7-864d001c1b22")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("44a1bcec-366e-4942-9099-c77add612475")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("44a1bcec-366e-4942-9099-c77add612475")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
