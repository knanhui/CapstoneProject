S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10253
Date: 2017-06-01 14:11:41+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000aa56, esi = 0xb37f5590
ebp = 0xbfb24b58, esp = 0xbfb239e0
eax = 0x00000000, ebx = 0xb37f9000
ecx = 0xb42e0010, edx = 0x00000002
eip = 0xb37f54af

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         8 KB
Cached:     164988 KB
VmPeak:      81140 KB
VmSize:      81140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16220 KB
VmRSS:       16220 KB
VmData:      20052 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10253 TID = 10253
10253 10255 10289 

Maps Information
b2bb6000 b2bc0000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bc6000 b2bd2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bd3000 b2bf4000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bf9000 b2bfa000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bfb000 b2c00000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c01000 b2c02000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c03000 b2c05000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c06000 b2c12000 r-xp /usr/lib/libdrm.so.2.4.0
b2c13000 b2c16000 r-xp /usr/lib/libdri2.so.0.0.0
b2c17000 b2c21000 r-xp /usr/lib/libtbm.so.1.0.0
b2c22000 b2c37000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c38000 b2c4a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b344c000 b347d000 r-xp /usr/lib/libidn.so.11.5.44
b347e000 b34a0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34a1000 b34b1000 r-xp /usr/lib/libcares.so.2.1.0
b34b2000 b34bb000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34bc000 b34c5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34c6000 b353d000 r-xp /usr/lib/libcurl.so.4.3.0
b353f000 b3551000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3552000 b3573000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b357a000 b357b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b357c000 b357d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b357e000 b3581000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3582000 b3585000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b368d000 b3693000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3694000 b37d8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37e8000 b37ea000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37eb000 b37ec000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ed000 b37f8000 r-xp /opt/usr/apps/org.example.example/bin/example
b37fa000 b3833000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4236000 b4241000 r-xp /lib/libnss_files-2.20-2014.11.so
b4243000 b424e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4250000 b4267000 r-xp /lib/libnsl-2.20-2014.11.so
b426b000 b4273000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4275000 b4299000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b429a000 b429b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b429c000 b429f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42a0000 b42a7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42a8000 b42b2000 r-xp /usr/lib/libsensord-share.so
b42b3000 b42cf000 r-xp /usr/lib/libsensor.so.1.2.0
b42d1000 b42da000 r-xp /usr/lib/libappcore-common.so.1.1
b42dd000 b42df000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42f4000 b42f6000 r-xp /usr/lib/libXau.so.6.0.0
b42f7000 b4319000 r-xp /usr/lib/libxcb.so.1.1.0
b431b000 b4324000 r-xp /lib/libcrypt-2.20-2014.11.so
b434d000 b434f000 r-xp /usr/lib/libiri.so
b4350000 b4376000 r-xp /lib/libexpat.so.1.5.2
b4378000 b43e3000 r-xp /usr/lib/libssl.so.1.0.0
b43e9000 b43f5000 r-xp /usr/lib/libethumb.so.1.13.0
b43f6000 b43fa000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43fb000 b464c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bc7000 b5bd7000 r-xp /usr/lib/libXi.so.6.1.0
b5bd8000 b5bda000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bdb000 b5be1000 r-xp /usr/lib/libXtst.so.6.1.0
b5be2000 b5bec000 r-xp /usr/lib/libXrender.so.1.3.0
b5bed000 b5bf6000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bf8000 b5bfa000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bfb000 b5c00000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c01000 b5c13000 r-xp /usr/lib/libXext.so.6.4.0
b5c14000 b5c16000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c17000 b5c19000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c1b000 b5d5d000 r-xp /usr/lib/libX11.so.6.3.0
b5d61000 b5d6b000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d6c000 b5d82000 r-xp /usr/lib/libudev.so.1.6.0
b5d85000 b5d89000 r-xp /lib/libattr.so.1.1.0
b5d8a000 b5db9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dbb000 b5dc1000 r-xp /usr/lib/libffi.so.6.0.2
b5dc2000 b5de5000 r-xp /lib/libz.so.1.2.8
b5de6000 b5de9000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dea000 b5f46000 r-xp /usr/lib/libxml2.so.2.9.2
b5f4c000 b6033000 r-xp /usr/lib/libstdc++.so.6.0.20
b6040000 b6043000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6044000 b6066000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6067000 b607b000 r-xp /lib/libresolv-2.20-2014.11.so
b607f000 b60a3000 r-xp /usr/lib/liblzma.so.5.0.3
b60a4000 b60a6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60a8000 b60b2000 r-xp /usr/lib/libembryo.so.1.13.0
b60b3000 b60dc000 r-xp /usr/lib/libpng12.so.0.50.0
b60dd000 b6126000 r-xp /usr/lib/libjpeg.so.8.0.2
b6137000 b613e000 r-xp /lib/librt-2.20-2014.11.so
b6140000 b615f000 r-xp /usr/lib/libector.so.1.13.0
b6162000 b618f000 r-xp /usr/lib/liblua-5.1.so
b6190000 b6220000 r-xp /usr/lib/libfreetype.so.6.11.3
b6224000 b6262000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6263000 b6279000 r-xp /usr/lib/libfribidi.so.0.3.1
b627a000 b62d3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62d6000 b6321000 r-xp /lib/libm-2.20-2014.11.so
b6323000 b6335000 r-xp /usr/lib/libeio.so.1.13.0
b6336000 b6339000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b633a000 b6340000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6341000 b6364000 r-xp /usr/lib/libefreet.so.1.13.0
b6367000 b6392000 r-xp /usr/lib/libeldbus.so.1.13.0
b6393000 b63c7000 r-xp /usr/lib/libecore_con.so.1.13.0
b63c9000 b63d2000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63d3000 b63dc000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63dd000 b63f0000 r-xp /usr/lib/libeo.so.1.13.0
b63f2000 b6405000 r-xp /usr/lib/libecore_input.so.1.13.0
b6406000 b640d000 r-xp /usr/lib/libecore_file.so.1.13.0
b640e000 b6431000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6432000 b645e000 r-xp /usr/lib/libeet.so.1.13.0
b6467000 b64d2000 r-xp /usr/lib/libeina.so.1.13.0
b64d5000 b64ec000 r-xp /usr/lib/libefl.so.1.13.0
b64ee000 b6655000 r-xp /usr/lib/libicuuc.so.51.1
b6663000 b686f000 r-xp /usr/lib/libicui18n.so.51.1
b6877000 b68c6000 r-xp /usr/lib/libecore_x.so.1.13.0
b68c8000 b68e2000 r-xp /lib/libgcc_s-4.9.so.1
b68e4000 b68e8000 r-xp /lib/libcap.so.2.21
b68e9000 b692f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6930000 b6937000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6939000 b698b000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b698d000 b6b18000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b1d000 b6beb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bee000 b6bf2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bf3000 b6c02000 r-xp /usr/lib/libvconf.so.0.2.45
b6c03000 b6c06000 r-xp /usr/lib/libvasum.so.0.3.1
b6c07000 b6c0a000 r-xp /usr/lib/libttrace.so.1.1
b6c0c000 b6c10000 r-xp /usr/lib/libiniparser.so.0
b6c11000 b6c41000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c42000 b6c4b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c4c000 b6c71000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c72000 b6c82000 r-xp /usr/lib/libunwind.so.8.0.1
b6c8c000 b6e3a000 r-xp /lib/libc-2.20-2014.11.so
b6e42000 b6f85000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f87000 b6fdf000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fe0000 b7014000 r-xp /usr/lib/libsystemd.so.0.4.0
b7017000 b70eb000 r-xp /usr/lib/libedje.so.1.13.0
b70ee000 b711a000 r-xp /usr/lib/libecore.so.1.13.0
b712b000 b7351000 r-xp /usr/lib/libevas.so.1.13.0
b7379000 b7391000 r-xp /lib/libpthread-2.20-2014.11.so
b7395000 b770f000 r-xp /usr/lib/libelementary.so.1.13.0
b772f000 b7733000 r-xp /usr/lib/libsmack.so.1.0.0
b7734000 b773d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b773e000 b7741000 r-xp /usr/lib/libdlog.so.0.0.0
b7742000 b7747000 r-xp /usr/lib/libbundle.so.0.1.22
b7748000 b774b000 r-xp /lib/libdl-2.20-2014.11.so
b774d000 b7772000 r-xp /usr/lib/libaul.so.0.1.0
b7775000 b7777000 r-xp /usr/lib/libappsvc.so.0.1.0
b7778000 b777d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b777e000 b7785000 r-xp /usr/lib/libappcore-efl.so.1.1
b7787000 b778c000 r-xp /usr/lib/libsys-assert.so
b778f000 b7790000 r-xp [vdso]
b7790000 b77b2000 r-xp /lib/ld-2.20-2014.11.so
b77b4000 b77bc000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10253)
Call Stack Count: 8
 0: create_base_gui + 0xc2f (0xb37f54af) [/opt/usr/apps/org.example.example/bin/example] + 0x84af
 1: app_create + 0x2c (0xb37f46ec) [/opt/usr/apps/org.example.example/bin/example] + 0x76ec
 2: (0xb777a65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 3: appcore_efl_main + 0x327 (0xb7781c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb777ac80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 5: main + 0x2e1 (0xb37f4661) [/opt/usr/apps/org.example.example/bin/example] + 0x7661
 6: (0xb77b6148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77b6148
 7: __libc_start_main + 0xde (0xb6ca3e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: forpet
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 Name[Settings] pos[3, 4] pageId[100001]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 14:11:31.718+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 14:11:31.718+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 14:11:31.718+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 14:11:31.718+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 14:11:31.938+0900 D/rpm-installer(10183): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 14:11:31.998+0900 D/PKGMGR_SERVER(10169): pkgmgr-server.c: sighandler(387) > child exit [10183]
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10183]
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 14:11:31.998+0900 E/PKGMGR_SERVER(10169): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 14:11:32.808+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 14:11:32.808+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 14:11:32.808+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.808+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 14:11:32.818+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10236, pid = 10238
06-01 14:11:32.818+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 14:11:32.818+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 14:11:32.818+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 10238
06-01 14:11:32.818+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 14:11:32.818+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 14:11:32.818+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 14:11:32.818+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 14:11:32.818+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 14:11:32.818+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10082, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.818+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 14:11:32.818+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 14:11:32.818+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 14:11:32.828+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 14:11:32.828+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10083) is sent.
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10083, signo: 10
06-01 14:11:32.828+0900 D/AUL     (10082): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 14:11:32.828+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyOTM4OTIvODEzNTM2AA==##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDIzOAA=##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 14:11:32.838+0900 D/AUL_PAD (10082): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 14:11:32.838+0900 I/CAPI_APPFW_APPLICATION(10082): app_main.c: ui_app_main(788) > app_efl_main
06-01 14:11:32.848+0900 D/LAUNCH  (10082): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 14:11:32.848+0900 D/APP_CORE(10082): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:11:32.868+0900 D/APP_CORE(10082): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:11:32.868+0900 D/AUL     (10082): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 14:11:32.868+0900 D/APP_CORE(10082): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42eb520
06-01 14:11:32.868+0900 D/LAUNCH  (10082): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 14:11:32.868+0900 I/CAPI_APPFW_APPLICATION(10082): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 14:11:32.918+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 14:11:32.918+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10082, appid: org.example.example
06-01 14:11:32.918+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:11:32.918+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:11:32.918+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 14:11:32.918+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 14:11:32.928+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(10082) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10082
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 14:11:32.928+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 14:11:32.928+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 318
06-01 14:11:33.058+0900 W/CRASH_MANAGER(10243): worker.c: worker_job(1204) > 11100826578611496293892
06-01 14:11:33.928+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 14:11:33.928+0900 D/AUL_PAD (10253): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 14:11:33.928+0900 D/AUL_AMD ( 2858): amd_launch.c: __grab_timeout_handler(1445) > pid(10082) ecore_x_pointer_ungrab
06-01 14:11:33.928+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 14:11:33.928+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 14:11:33.928+0900 W/AUL_AMD ( 2858): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
06-01 14:11:33.948+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:11:33.958+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:11:33.958+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 10082 pgid = 10082
06-01 14:11:33.968+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(10082)
06-01 14:11:33.978+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 14:11:33.978+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 14:11:33.978+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 14:11:33.978+0900 E/AUL_PAD ( 3003): launchpad.c: main(688) > error reading sigchld info
06-01 14:11:33.988+0900 I/ESD     ( 3017): esd_main.c: __esd_app_dead_handler(1771) > pid: 10082
06-01 14:11:33.988+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 10082 is termianted
06-01 14:11:33.988+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 14:11:33.988+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 10082
06-01 14:11:33.988+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 10082
06-01 14:11:33.988+0900 D/AUL_AMD ( 2858): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 14:11:33.988+0900 E/AUL_AMD ( 2858): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 14:11:33.988+0900 D/AUL_AMD ( 2858): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 14:11:33.988+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:11:33.988+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:11:33.988+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.836
06-01 14:11:33.998+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 10082
06-01 14:11:33.998+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 14:11:34.428+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 14:11:34.428+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 14:11:34.448+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 14:11:34.898+0900 E/VCONF   (10243): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 14:11:34.898+0900 E/VCONF   (10243): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 14:11:34.898+0900 E/VCONF   (10243): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 14:11:34.898+0900 E/VCONF   (10243): vconf.c: vconf_get_str(2891) > vconf_get_str(10243) : db/menu_widget/language error
06-01 14:11:34.898+0900 E/PKGMGR_INFO(10243): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 14:11:34.898+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:34.898+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:34.978+0900 D/AUL_PAD (10253): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 14:11:34.978+0900 D/AUL_PAD (10253): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 14:11:34.998+0900 D/AUL_PAD (10253): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9115760
06-01 14:11:34.998+0900 D/AUL_PAD (10253): preload.h: __preload_init(69) > get pre-initialization function
06-01 14:11:34.998+0900 D/AUL_PAD (10253): preload.h: __preload_init(73) > get shutdown function
06-01 14:11:34.998+0900 D/AUL_PAD (10253): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9115a40
06-01 14:11:35.008+0900 E/VCONF   (10243): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 14:11:35.018+0900 D/AUL_PAD (10253): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9117640
06-01 14:11:35.018+0900 E/VCONF   (10243): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 14:11:35.018+0900 E/VCONF   (10243): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 14:11:35.018+0900 E/VCONF   (10243): vconf.c: vconf_get_str(2891) > vconf_get_str(10243) : db/menu_widget/language error
06-01 14:11:35.018+0900 E/PKGMGR_INFO(10243): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 14:11:35.018+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:35.018+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:35.018+0900 D/AUL_PAD (10253): preload.h: __preload_init(69) > get pre-initialization function
06-01 14:11:35.028+0900 D/AUL_PAD (10253): preload.h: __preload_init(73) > get shutdown function
06-01 14:11:35.028+0900 D/AUL_PAD (10253): preexec.h: __preexec_init(76) > preexec start
06-01 14:11:35.028+0900 D/AUL_PAD (10253): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 14:11:35.028+0900 D/AUL     (10253): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 14:11:35.028+0900 D/AUL     (10253): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 14:11:35.028+0900 D/AUL     (10253): process_pool.c: __connect_to_launchpad(132) > send(10253) : 4
06-01 14:11:35.028+0900 D/AUL     (10253): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 14:11:35.028+0900 D/AUL_PAD ( 3003): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 10253
06-01 14:11:35.128+0900 E/VCONF   (10243): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 14:11:35.128+0900 E/VCONF   (10243): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 14:11:35.128+0900 E/VCONF   (10243): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 14:11:35.128+0900 E/VCONF   (10243): vconf.c: vconf_get_str(2891) > vconf_get_str(10243) : db/menu_widget/language error
06-01 14:11:35.128+0900 E/PKGMGR_INFO(10243): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 14:11:35.128+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:35.128+0900 D/PKGMGR_INFO(10243): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 14:11:35.208+0900 E/VCONF   (10243): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 14:11:35.208+0900 E/VCONF   (10243): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 14:11:35.208+0900 E/VCONF   (10243): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 14:11:35.208+0900 E/VCONF   (10243): vconf.c: vconf_get_str(2891) > vconf_get_str(10243) : db/menu_widget/language error
06-01 14:11:35.208+0900 E/PKGMGR_INFO(10243): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 14:11:35.228+0900 D/AUL_PAD (10253): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 14:11:35.228+0900 D/AUL_PAD (10253): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 14:11:35.238+0900 D/AUL_PAD (10253): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 14:11:35.238+0900 D/AUL_PAD (10253): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 14:11:36.148+0900 D/LAUNCH  (10257): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
06-01 14:11:36.158+0900 D/PKGMGR_INFO(10257): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 14:11:36.158+0900 D/PKGMGR_INFO(10257): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 14:11:36.158+0900 D/AUL     (10257): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 10257 is org.tizen.crash-popup
06-01 14:11:36.348+0900 D/APP_CORE(10257): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:11:36.348+0900 D/APP_CORE(10257): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
06-01 14:11:36.358+0900 D/APP_CORE(10257): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:11:36.378+0900 D/APP_CORE(10257): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:11:36.378+0900 D/APP_CORE(10257): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7701520
06-01 14:11:36.378+0900 D/LAUNCH  (10257): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
06-01 14:11:36.458+0900 D/APP_CORE(10257): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:11:36.468+0900 D/LAUNCH  (10257): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
06-01 14:11:36.478+0900 D/APP_CORE(10257): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 14:11:36.598+0900 E/RESOURCED( 2893): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
06-01 14:11:37.928+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(10082) status(4)
06-01 14:11:39.498+0900 E/EFL     (10257): eldbus<10257> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-DZvElkZACI: Connection refused
06-01 14:11:39.508+0900 E/EFL     (10257): <10257> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
06-01 14:11:39.508+0900 E/EFL     (10257): elementary<10257> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
06-01 14:11:39.508+0900 D/APP_CORE(10257): appcore.c: __aul_handler(587) > [APP 10257]     AUL event: AUL_START
06-01 14:11:39.508+0900 I/APP_CORE(10257): appcore-efl.c: __do_app(496) > [APP 10257] Event: RESET State: CREATED
06-01 14:11:39.508+0900 D/APP_CORE(10257): appcore-efl.c: __do_app(527) > [APP 10257] RESET
06-01 14:11:39.508+0900 D/LAUNCH  (10257): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-01 14:11:39.518+0900 D/APP_CORE(10257): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 14:11:39.518+0900 D/APP_CORE(10257): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 14:11:39.518+0900 E/SYSPOPUP(10257): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 14:11:39.518+0900 E/SYSPOPUP(10257): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 14:11:39.518+0900 E/SYSPOPUP(10257): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-01 14:11:39.518+0900 D/LAUNCH  (10257): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-01 14:11:39.518+0900 D/APP_CORE(10257): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 14:11:39.558+0900 D/AUL     (10257): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-01 14:11:39.558+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 22
06-01 14:11:39.558+0900 W/AUL_AMD ( 2858): amd_request.c: __request_handler(1056) > app status : 5
06-01 14:11:39.558+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(10257) status(5)
06-01 14:11:39.568+0900 D/APP_CORE(10257): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-01 14:11:39.578+0900 E/EFL     (10257): eo<10257> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-01 14:11:39.578+0900 E/EFL     (10257): eo<10257> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-01 14:11:40.828+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
06-01 14:11:40.838+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
06-01 14:11:40.958+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
06-01 14:11:40.958+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
06-01 14:11:40.958+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
06-01 14:11:40.958+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
06-01 14:11:40.958+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[405.00][397.00] to[405.00][397.00]!
06-01 14:11:40.958+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
06-01 14:11:40.968+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200050 
06-01 14:11:40.978+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [49]MenuBox clicked
06-01 14:11:40.998+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
06-01 14:11:40.998+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 14:11:41.008+0900 D/AUL     ( 2945): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-01 14:11:41.008+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 14:11:41.008+0900 D/AUL     ( 2945): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
06-01 14:11:41.008+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
06-01 14:11:41.008+0900 D/AUL     ( 2945): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-01 14:11:41.018+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 14:11:41.018+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 14:11:41.018+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
06-01 14:11:41.018+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 2945
06-01 14:11:41.048+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2443) > win(c00002) ecore_x_pointer_grab(1)
06-01 14:11:41.048+0900 D/AUL_AMD ( 2858): amd_key.c: _key_grab(243) > _key_grab, win : c00002
06-01 14:11:41.068+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2448) > back key grab
06-01 14:11:41.068+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 14:11:41.068+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 14:11:41.068+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 14:11:41.068+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 14:11:41.078+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 14:11:41.078+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 14:11:41.078+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 14:11:41.078+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 14:11:41.078+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 884 / 884
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10253, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 14:11:41.078+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 14:11:41.078+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 14:11:41.078+0900 D/AUL     (10253): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10255) is sent.
06-01 14:11:41.078+0900 D/AUL     (10253): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10255, signo: 10
06-01 14:11:41.078+0900 D/AUL     (10253): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0OTYyOTM5MDEvMTc1MjQA##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTQ1AA==##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 14:11:41.078+0900 D/AUL_PAD (10253): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 14:11:41.088+0900 I/CAPI_APPFW_APPLICATION(10253): app_main.c: ui_app_main(788) > app_efl_main
06-01 14:11:41.088+0900 D/LAUNCH  (10253): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 14:11:41.088+0900 D/APP_CORE(10253): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:11:41.088+0900 D/APP_CORE(10253): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 14:11:41.088+0900 D/APP_CORE(10253): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:11:41.118+0900 D/APP_CORE(10253): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:11:41.118+0900 D/AUL     (10253): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 14:11:41.118+0900 D/APP_CORE(10253): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42da520
06-01 14:11:41.118+0900 D/LAUNCH  (10253): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 14:11:41.118+0900 I/CAPI_APPFW_APPLICATION(10253): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 14:11:41.178+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 14:11:41.178+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10253, appid: org.example.example
06-01 14:11:41.178+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:11:41.178+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:11:41.178+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 14:11:41.178+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 14:11:41.178+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(10253) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 14:11:41.178+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(425) > launch request result : 10253
06-01 14:11:41.178+0900 E/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
06-01 14:11:41.178+0900 D/test-log( 2945): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
06-01 14:11:41.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10253
06-01 14:11:41.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 14:11:41.178+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 14:11:41.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 316
06-01 14:11:41.228+0900 W/CRASH_MANAGER(10243): worker.c: worker_job(1204) > 1110253657861149629390
