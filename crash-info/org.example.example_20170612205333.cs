S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 5024
Date: 2017-06-12 20:53:33+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x35

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7771f84
ebp = 0xbff854f8, esp = 0xbff84fb8
eax = 0x00000035, ebx = 0xb6df5000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6cbf9c7

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         8 KB
Cached:     166956 KB
VmPeak:     122468 KB
VmSize:     122468 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35176 KB
VmRSS:       35176 KB
VmData:      52552 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5024 TID = 5024
5024 5027 5228 5229 5235 

Maps Information
b0eae000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1804000 b180b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180e000 b1815000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1892000 b1896000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b6b000 b2b75000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b7b000 b2b87000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b88000 b2ba9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bae000 b2baf000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bb0000 b2bb5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bb6000 b2bb7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bb8000 b2bba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bbb000 b2bbd000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bbe000 b2bca000 r-xp /usr/lib/libdrm.so.2.4.0
b2bcb000 b2bce000 r-xp /usr/lib/libdri2.so.0.0.0
b2bcf000 b2bd9000 r-xp /usr/lib/libtbm.so.1.0.0
b2bda000 b2bef000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf0000 b2c02000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3404000 b3435000 r-xp /usr/lib/libidn.so.11.5.44
b3436000 b3458000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3459000 b3469000 r-xp /usr/lib/libcares.so.2.1.0
b346a000 b3473000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3474000 b347d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b347e000 b34f5000 r-xp /usr/lib/libcurl.so.4.3.0
b34f7000 b3509000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b350a000 b352b000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3532000 b3533000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3534000 b3535000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3536000 b3539000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b353a000 b353d000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3645000 b364b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b364c000 b3790000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37a0000 b37a1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37a2000 b37af000 r-xp /opt/usr/apps/org.example.example/bin/example
b37b2000 b37eb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41ee000 b41f9000 r-xp /lib/libnss_files-2.20-2014.11.so
b41fb000 b4206000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4208000 b421f000 r-xp /lib/libnsl-2.20-2014.11.so
b4223000 b422b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b422d000 b4251000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4252000 b4253000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4254000 b4257000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4258000 b425f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4260000 b426a000 r-xp /usr/lib/libsensord-share.so
b426b000 b4287000 r-xp /usr/lib/libsensor.so.1.2.0
b4289000 b4292000 r-xp /usr/lib/libappcore-common.so.1.1
b4295000 b4297000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42ac000 b42ae000 r-xp /usr/lib/libXau.so.6.0.0
b42af000 b42d1000 r-xp /usr/lib/libxcb.so.1.1.0
b42d3000 b42dc000 r-xp /lib/libcrypt-2.20-2014.11.so
b4305000 b4307000 r-xp /usr/lib/libiri.so
b4308000 b432e000 r-xp /lib/libexpat.so.1.5.2
b4330000 b439b000 r-xp /usr/lib/libssl.so.1.0.0
b43a1000 b43ad000 r-xp /usr/lib/libethumb.so.1.13.0
b43ae000 b43b2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43b3000 b4604000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b7f000 b5b8f000 r-xp /usr/lib/libXi.so.6.1.0
b5b90000 b5b92000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b93000 b5b99000 r-xp /usr/lib/libXtst.so.6.1.0
b5b9a000 b5ba4000 r-xp /usr/lib/libXrender.so.1.3.0
b5ba5000 b5bae000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bb0000 b5bb2000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bb3000 b5bb8000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bb9000 b5bcb000 r-xp /usr/lib/libXext.so.6.4.0
b5bcc000 b5bce000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd3000 b5d15000 r-xp /usr/lib/libX11.so.6.3.0
b5d19000 b5d23000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d24000 b5d3a000 r-xp /usr/lib/libudev.so.1.6.0
b5d3d000 b5d41000 r-xp /lib/libattr.so.1.1.0
b5d42000 b5d71000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d73000 b5d79000 r-xp /usr/lib/libffi.so.6.0.2
b5d7a000 b5d9d000 r-xp /lib/libz.so.1.2.8
b5d9e000 b5da1000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5da2000 b5efe000 r-xp /usr/lib/libxml2.so.2.9.2
b5f04000 b5feb000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ff8000 b5ffb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ffc000 b601e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b601f000 b6033000 r-xp /lib/libresolv-2.20-2014.11.so
b6037000 b605b000 r-xp /usr/lib/liblzma.so.5.0.3
b605c000 b605e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6060000 b606a000 r-xp /usr/lib/libembryo.so.1.13.0
b606b000 b6094000 r-xp /usr/lib/libpng12.so.0.50.0
b6095000 b60de000 r-xp /usr/lib/libjpeg.so.8.0.2
b60ef000 b60f6000 r-xp /lib/librt-2.20-2014.11.so
b60f8000 b6117000 r-xp /usr/lib/libector.so.1.13.0
b611a000 b6147000 r-xp /usr/lib/liblua-5.1.so
b6148000 b61d8000 r-xp /usr/lib/libfreetype.so.6.11.3
b61dc000 b621a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b621b000 b6231000 r-xp /usr/lib/libfribidi.so.0.3.1
b6232000 b628b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b628e000 b62d9000 r-xp /lib/libm-2.20-2014.11.so
b62db000 b62ed000 r-xp /usr/lib/libeio.so.1.13.0
b62ee000 b62f1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62f2000 b62f8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62f9000 b631c000 r-xp /usr/lib/libefreet.so.1.13.0
b631f000 b634a000 r-xp /usr/lib/libeldbus.so.1.13.0
b634b000 b637f000 r-xp /usr/lib/libecore_con.so.1.13.0
b6381000 b638a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b638b000 b6394000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6395000 b63a8000 r-xp /usr/lib/libeo.so.1.13.0
b63aa000 b63bd000 r-xp /usr/lib/libecore_input.so.1.13.0
b63be000 b63c5000 r-xp /usr/lib/libecore_file.so.1.13.0
b63c6000 b63e9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ea000 b6416000 r-xp /usr/lib/libeet.so.1.13.0
b641f000 b648a000 r-xp /usr/lib/libeina.so.1.13.0
b648d000 b64a4000 r-xp /usr/lib/libefl.so.1.13.0
b64a6000 b660d000 r-xp /usr/lib/libicuuc.so.51.1
b661b000 b6827000 r-xp /usr/lib/libicui18n.so.51.1
b682f000 b687e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6880000 b689a000 r-xp /lib/libgcc_s-4.9.so.1
b689c000 b68a0000 r-xp /lib/libcap.so.2.21
b68a1000 b68e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68e8000 b68ef000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68f1000 b6943000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6945000 b6ad0000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ad5000 b6ba3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ba6000 b6baa000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bab000 b6bba000 r-xp /usr/lib/libvconf.so.0.2.45
b6bbb000 b6bbe000 r-xp /usr/lib/libvasum.so.0.3.1
b6bbf000 b6bc2000 r-xp /usr/lib/libttrace.so.1.1
b6bc4000 b6bc8000 r-xp /usr/lib/libiniparser.so.0
b6bc9000 b6bf9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bfa000 b6c03000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c04000 b6c29000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2a000 b6c3a000 r-xp /usr/lib/libunwind.so.8.0.1
b6c44000 b6df2000 r-xp /lib/libc-2.20-2014.11.so
b6dfa000 b6f3d000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f3f000 b6f97000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f98000 b6fcc000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fcf000 b70a3000 r-xp /usr/lib/libedje.so.1.13.0
b70a6000 b70d2000 r-xp /usr/lib/libecore.so.1.13.0
b70e3000 b7309000 r-xp /usr/lib/libevas.so.1.13.0
b7331000 b7349000 r-xp /lib/libpthread-2.20-2014.11.so
b734d000 b76c7000 r-xp /usr/lib/libelementary.so.1.13.0
b76e7000 b76eb000 r-xp /usr/lib/libsmack.so.1.0.0
b76ec000 b76f5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76f6000 b76f9000 r-xp /usr/lib/libdlog.so.0.0.0
b76fa000 b76ff000 r-xp /usr/lib/libbundle.so.0.1.22
b7700000 b7703000 r-xp /lib/libdl-2.20-2014.11.so
b7705000 b772a000 r-xp /usr/lib/libaul.so.0.1.0
b772d000 b772f000 r-xp /usr/lib/libappsvc.so.0.1.0
b7730000 b7735000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7736000 b773d000 r-xp /usr/lib/libappcore-efl.so.1.1
b773f000 b7744000 r-xp /usr/lib/libsys-assert.so
b7747000 b7748000 r-xp [vdso]
b7748000 b776a000 r-xp /lib/ld-2.20-2014.11.so
b776c000 b7774000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5024)
Call Stack Count: 3
 0: strchrnul + 0x17 (0xb6cbf9c7) [/lib/libc.so.6] + 0x7b9c7
 1: __vsnprintf_chk + 0xac (0xb6d397ac) [/lib/libc.so.6] + 0xf57ac
 2: (0xb6ba40d4) [/usr/lib/libsqlite3.so.0] + 0xb6ba40d4
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
ge-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[1, 3] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[2, 3] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[3, 3] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[4, 3] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[1, 4] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-12 20:53:25.327+0900 D/BADGE   ( 2866): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-12 20:53:25.327+0900 E/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-12 20:53:25.327+0900 D/cluster-home( 2866): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-12 20:53:25.327+0900 D/cluster-view( 2866): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-12 20:53:25.487+0900 D/rpm-installer( 5170): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-12 20:53:25.487+0900 D/rpm-installer( 5170): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-12 20:53:25.487+0900 D/rpm-installer( 5170): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-12 20:53:25.487+0900 D/rpm-installer( 5170): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-12 20:53:25.487+0900 D/PKGMGR_SERVER( 5155): pkgmgr-server.c: sighandler(387) > child exit [5170]
06-12 20:53:25.487+0900 E/PKGMGR_SERVER( 5155): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5170]
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-12 20:53:25.717+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.717+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.717+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-12 20:53:25.717+0900 D/AUL     ( 2740): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5222, pid = 5224
06-12 20:53:25.717+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.717+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.717+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-12 20:53:25.717+0900 E/AUL_AMD ( 2740): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-12 20:53:25.717+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 5224
06-12 20:53:25.717+0900 E/AUL_AMD ( 2740): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-12 20:53:25.717+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-12 20:53:25.717+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-12 20:53:25.717+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-12 20:53:25.717+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-12 20:53:25.717+0900 W/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-12 20:53:25.717+0900 D/AUL     ( 2914): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5024, bin path: /opt/usr/apps/org.example.example/bin/example
06-12 20:53:25.717+0900 W/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(265) > Check app launching
06-12 20:53:25.717+0900 D/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-12 20:53:25.727+0900 D/AUL     ( 5024): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5027) is sent.
06-12 20:53:25.727+0900 D/AUL     ( 5024): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5027, signo: 10
06-12 20:53:25.727+0900 D/RESOURCED( 2846): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-12 20:53:25.727+0900 D/RESOURCED( 2846): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-12 20:53:25.727+0900 E/RESOURCED( 2846): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-12 20:53:25.727+0900 D/AUL     ( 5024): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTcyNjg0MDUvNzIyNjg3AA==##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1MjI0AA==##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-12 20:53:25.727+0900 D/AUL_PAD ( 5024): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-12 20:53:25.727+0900 I/CAPI_APPFW_APPLICATION( 5024): app_main.c: ui_app_main(788) > app_efl_main
06-12 20:53:25.727+0900 D/LAUNCH  ( 5024): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-12 20:53:25.727+0900 D/APP_CORE( 5024): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-12 20:53:25.727+0900 D/APP_CORE( 5024): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-12 20:53:25.727+0900 D/APP_CORE( 5024): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-12 20:53:25.737+0900 D/APP_CORE( 5024): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-12 20:53:25.737+0900 D/AUL     ( 5024): app_sock.c: __create_server_sock(156) > pg path - already exists
06-12 20:53:25.737+0900 D/APP_CORE( 5024): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4292520
06-12 20:53:25.737+0900 D/LAUNCH  ( 5024): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-12 20:53:25.737+0900 I/CAPI_APPFW_APPLICATION( 5024): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-12 20:53:25.797+0900 D/LAUNCH  ( 5024): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-12 20:53:25.797+0900 D/APP_CORE( 5024): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-12 20:53:25.807+0900 E/E17     ( 2760): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
06-12 20:53:25.807+0900 D/APP_CORE( 5024): appcore.c: __aul_handler(587) > [APP 5024]     AUL event: AUL_START
06-12 20:53:25.807+0900 I/APP_CORE( 5024): appcore-efl.c: __do_app(496) > [APP 5024] Event: RESET State: CREATED
06-12 20:53:25.807+0900 D/APP_CORE( 5024): appcore-efl.c: __do_app(527) > [APP 5024] RESET
06-12 20:53:25.807+0900 D/LAUNCH  ( 5024): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-12 20:53:25.807+0900 D/APP_CORE( 5024): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-12 20:53:25.807+0900 D/APP_CORE( 5024): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-12 20:53:25.807+0900 I/CAPI_APPFW_APPLICATION( 5024): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-12 20:53:25.807+0900 D/AUL     ( 5024): service.c: __set_bundle(186) > __set_bundle
06-12 20:53:25.807+0900 D/LAUNCH  ( 5024): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-12 20:53:25.807+0900 D/APP_CORE( 5024): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-12 20:53:25.807+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 20:53:25.807+0900 E/EFL     ( 5024): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 20:53:25.807+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 20:53:25.807+0900 E/EFL     ( 5024): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 20:53:25.807+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 20:53:25.807+0900 E/EFL     ( 5024): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 20:53:25.807+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 20:53:25.807+0900 E/EFL     ( 5024): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 20:53:25.807+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 20:53:25.807+0900 E/EFL     ( 5024): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 20:53:25.817+0900 D/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-12 20:53:25.817+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5024, appid: org.example.example
06-12 20:53:25.817+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-12 20:53:25.817+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
06-12 20:53:25.817+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
06-12 20:53:25.817+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-12 20:53:25.817+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(5024) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-12 20:53:25.817+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 5024
06-12 20:53:25.817+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-12 20:53:25.817+0900 E/RESOURCED( 2846): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-12 20:53:25.817+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(888) > available memory = 319
06-12 20:53:25.837+0900 E/E17     ( 2760): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
06-12 20:53:25.857+0900 W/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5024
06-12 20:53:25.857+0900 E/EFL     ( 2760): eo<2760> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-12 20:53:25.857+0900 E/EFL     ( 2760): eo<2760> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-12 20:53:25.867+0900 D/INDICATOR( 2850): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-12 20:53:25.867+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
06-12 20:53:25.867+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.867+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-12 20:53:25.867+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5024 is org.example.example
06-12 20:53:25.867+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5024 : 0
06-12 20:53:25.867+0900 D/AUL     ( 2930): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-12 20:53:25.887+0900 D/INDICATOR( 2850): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-12 20:53:25.887+0900 D/INDICATOR( 2850): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-12 20:53:25.887+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-12 20:53:25.887+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-12 20:53:25.887+0900 D/INDICATOR( 2850): main.c: _rotate_window(252) > port :: hide more icon
06-12 20:53:25.937+0900 D/APP_CORE( 5024): appcore.c: __prt_ltime(236) > [APP 5024] first idle after reset: 218 msec
06-12 20:53:25.937+0900 W/APP_CORE( 5024): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
06-12 20:53:25.937+0900 D/APP_CORE( 5024): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
06-12 20:53:25.937+0900 D/APP_CORE( 5024): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-12 20:53:25.937+0900 D/AUL     ( 5024): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-12 20:53:25.937+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
06-12 20:53:26.157+0900 E/E17     ( 2760): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-12 20:53:26.157+0900 I/APP_CORE( 5024): appcore-efl.c: __do_app(496) > [APP 5024] Event: RESUME State: CREATED
06-12 20:53:26.157+0900 D/LAUNCH  ( 5024): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __do_app(607) > [APP 5024] RESUME
06-12 20:53:26.157+0900 I/APP_CORE( 5024): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-12 20:53:26.157+0900 I/APP_CORE( 5024): appcore-efl.c: __do_app(614) > [APP 5024] Initial Launching, call the resume_cb
06-12 20:53:26.157+0900 I/CAPI_APPFW_APPLICATION( 5024): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-12 20:53:26.157+0900 D/LAUNCH  ( 5024): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-12 20:53:26.157+0900 D/LAUNCH  ( 5024): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-12 20:53:26.157+0900 D/APP_CORE( 5024): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-12 20:53:26.157+0900 E/APP_CORE( 5024): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-12 20:53:26.157+0900 D/APP_CORE( 2866): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-12 20:53:26.157+0900 D/APP_CORE( 2866): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-12 20:53:26.157+0900 D/APP_CORE( 2866): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-12 20:53:26.157+0900 I/APP_CORE( 2866): appcore-efl.c: __do_app(496) > [APP 2866] Event: PAUSE State: RUNNING
06-12 20:53:26.157+0900 D/APP_CORE( 2866): appcore-efl.c: __do_app(565) > [APP 2866] PAUSE
06-12 20:53:26.157+0900 I/CAPI_APPFW_APPLICATION( 2866): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-12 20:53:26.157+0900 E/cluster-home( 2866): homescreen.cpp: OnPause(84) >  app pause
06-12 20:53:26.157+0900 D/cluster-view( 2866): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-12 20:53:26.157+0900 D/cluster-view( 2866): homescreen-view-manager.cpp: AppPause(923) >  END
06-12 20:53:26.157+0900 D/APP_CORE( 2866): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-12 20:53:26.157+0900 E/APP_CORE( 2866): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-12 20:53:26.157+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2866) status(4)
06-12 20:53:26.157+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2866) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-12 20:53:26.157+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-12 20:53:26.157+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2866, appid: org.tizen.homescreen, status: bg
06-12 20:53:26.157+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(5024) status(3)
06-12 20:53:26.157+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-12 20:53:26.167+0900 D/DATA_PROVIDER_MASTER( 2921): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2866 is paused
06-12 20:53:26.167+0900 D/DATA_PROVIDER_MASTER( 2921): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-12 20:53:26.167+0900 I/CAPI_WIDGET_APPLICATION( 3014): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-12 20:53:26.167+0900 I/CAPI_WIDGET_APPLICATION( 3014): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-12 20:53:26.167+0900 W/AUL     ( 3014): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3014, appid: org.tizen.calendar.widget, status: bg
06-12 20:53:26.167+0900 D/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3014, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-12 20:53:26.167+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3014
06-12 20:53:26.167+0900 D/RESOURCED( 2846): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3014, appname = org.tizen.calendar.widget
06-12 20:53:26.167+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3014
06-12 20:53:26.177+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-12 20:53:26.177+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-12 20:53:26.177+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(5024) status(3)
06-12 20:53:26.177+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(5024) appid(org.example.example) pkgid(org.example.example) status(3)
06-12 20:53:26.177+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-12 20:53:26.177+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5024, appid: org.example.example, status: fg
06-12 20:53:26.177+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5024
06-12 20:53:26.177+0900 D/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5024, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-12 20:53:26.177+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5024
06-12 20:53:26.217+0900 D/RESOURCED( 2846): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5024, appname = org.example.example, pkgname = org.example.example
06-12 20:53:26.217+0900 D/RESOURCED( 2846): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5024, appname = org.example.example
06-12 20:53:26.217+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5024
06-12 20:53:26.217+0900 I/RESOURCED( 2846): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-12 20:53:26.217+0900 I/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-12 20:53:26.247+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(5024) status(0)
06-12 20:53:26.827+0900 D/AUL_PAD ( 2914): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-12 20:53:26.827+0900 D/AUL_PAD ( 5231): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-12 20:53:26.827+0900 D/AUL_PAD ( 2914): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-12 20:53:26.827+0900 E/RESOURCED( 2846): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.340
06-12 20:53:26.997+0900 E/PKGMGR_SERVER( 5155): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-12 20:53:26.997+0900 E/PKGMGR_SERVER( 5155): pkgmgr-server.c: main(2265) > package manager server terminated.
06-12 20:53:27.327+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-12 20:53:27.327+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
06-12 20:53:27.337+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
06-12 20:53:27.847+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(588) > sleeping 1 sec...
06-12 20:53:27.847+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-12 20:53:27.857+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b78cb760
06-12 20:53:27.857+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(69) > get pre-initialization function
06-12 20:53:27.857+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(73) > get shutdown function
06-12 20:53:27.867+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b78cba40
06-12 20:53:27.877+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b78cd640
06-12 20:53:27.877+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(69) > get pre-initialization function
06-12 20:53:27.877+0900 D/AUL_PAD ( 5231): preload.h: __preload_init(73) > get shutdown function
06-12 20:53:27.877+0900 D/AUL_PAD ( 5231): preexec.h: __preexec_init(76) > preexec start
06-12 20:53:27.877+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-12 20:53:27.877+0900 D/AUL     ( 5231): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-12 20:53:27.877+0900 D/AUL     ( 5231): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-12 20:53:27.877+0900 D/AUL     ( 5231): process_pool.c: __connect_to_launchpad(132) > send(5231) : 4
06-12 20:53:27.877+0900 D/AUL     ( 5231): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-12 20:53:27.877+0900 D/AUL_PAD ( 2914): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5231
06-12 20:53:28.027+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-12 20:53:28.037+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-12 20:53:28.037+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-12 20:53:28.037+0900 D/AUL_PAD ( 5231): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-12 20:53:29.957+0900 E/CAPI_NETWORK_WIFI( 2850): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-12 20:53:29.957+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-12 20:53:29.957+0900 E/INDICATOR( 2850): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-12 20:53:29.957+0900 E/INDICATOR( 2850): 
06-12 20:53:30.317+0900 I/user_tag0( 5024): /opt/usr/apps/org.example.example/data/feeding.db
06-12 20:53:30.327+0900 I/tag     ( 5024): eonji~
06-12 20:53:30.407+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600b4f 
06-12 20:53:31.167+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-12 20:53:31.167+0900 I/APP_CORE( 2866): appcore-efl.c: __do_app(496) > [APP 2866] Event: MEM_FLUSH State: PAUSED
06-12 20:53:31.167+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-12 20:53:31.167+0900 D/APP_CORE( 2866): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2866
06-12 20:53:31.167+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-12 20:53:31.167+0900 D/RESOURCED( 2846): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2866
06-12 20:53:31.407+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2600002
06-12 20:53:31.867+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600b4f 
06-12 20:53:32.007+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.007+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.037+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.047+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.047+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.047+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.047+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.057+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.057+0900 E/EFL     ( 5024): edje<5024> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 20:53:32.077+0900 D/IMMODULE( 5024): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-12 20:53:32.077+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 20:53:32.077+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.077+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 20:53:32.077+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.087+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 20:53:32.097+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_QUERY( 5024): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 20:53:32.097+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 20:53:32.097+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.097+0900 D/IMMODULE( 5024): scim_panel_client.cpp: open_connection(162) > 
06-12 20:53:32.097+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-12 20:53:32.097+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.107+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-12 20:53:32.107+0900 D/ISF_SOCKET( 5024): scim_socket.cpp: connect(524) > connect() succeeded
06-12 20:53:32.107+0900 D/IMMODULE( 5024): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-12 20:53:32.997+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x600b4f 
06-12 20:53:33.197+0900 I/tag     ( 5024): insert
06-12 20:53:33.257+0900 W/CRASH_MANAGER( 5237): worker.c: worker_job(1204) > 1105024657861149726841
