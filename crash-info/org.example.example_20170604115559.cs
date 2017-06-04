S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 7865
Date: 2017-06-04 11:55:59+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x37

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7780f84
ebp = 0xbf8c4338, esp = 0xbf8c3df8
eax = 0x00000037, ebx = 0xb6e04000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6cce9c7

Memory Information
MemTotal:      123 KB
MemFree:        25 KB
Buffers:         7 KB
Cached:     180436 KB
VmPeak:     121292 KB
VmSize:     115312 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34104 KB
VmRSS:       28000 KB
VmData:      45400 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7865 TID = 7865
7865 7866 8028 8029 8034 

Maps Information
b0ebf000 b0ec6000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1804000 b181c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b181d000 b1824000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18a1000 b18a5000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b7a000 b2b84000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b8a000 b2b96000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b97000 b2bb8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bbd000 b2bbe000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bbf000 b2bc4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bc5000 b2bc6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc7000 b2bc9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bca000 b2bcc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bcd000 b2bd9000 r-xp /usr/lib/libdrm.so.2.4.0
b2bda000 b2bdd000 r-xp /usr/lib/libdri2.so.0.0.0
b2bde000 b2be8000 r-xp /usr/lib/libtbm.so.1.0.0
b2be9000 b2bfe000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bff000 b2c11000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3413000 b3444000 r-xp /usr/lib/libidn.so.11.5.44
b3445000 b3467000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3468000 b3478000 r-xp /usr/lib/libcares.so.2.1.0
b3479000 b3482000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3483000 b348c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b348d000 b3504000 r-xp /usr/lib/libcurl.so.4.3.0
b3506000 b3518000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3519000 b353a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3541000 b3542000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3543000 b3544000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3545000 b3548000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3549000 b354c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3654000 b365a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b365b000 b379f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37b0000 b37b1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b2000 b37bf000 r-xp /opt/usr/apps/org.example.example/bin/example
b37c1000 b37fa000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41fd000 b4208000 r-xp /lib/libnss_files-2.20-2014.11.so
b420a000 b4215000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4217000 b422e000 r-xp /lib/libnsl-2.20-2014.11.so
b4232000 b423a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b423c000 b4260000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4261000 b4262000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4263000 b4266000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4267000 b426e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b426f000 b4279000 r-xp /usr/lib/libsensord-share.so
b427a000 b4296000 r-xp /usr/lib/libsensor.so.1.2.0
b4298000 b42a1000 r-xp /usr/lib/libappcore-common.so.1.1
b42a4000 b42a6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42bb000 b42bd000 r-xp /usr/lib/libXau.so.6.0.0
b42be000 b42e0000 r-xp /usr/lib/libxcb.so.1.1.0
b42e2000 b42eb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4314000 b4316000 r-xp /usr/lib/libiri.so
b4317000 b433d000 r-xp /lib/libexpat.so.1.5.2
b433f000 b43aa000 r-xp /usr/lib/libssl.so.1.0.0
b43b0000 b43bc000 r-xp /usr/lib/libethumb.so.1.13.0
b43bd000 b43c1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43c2000 b4613000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b8e000 b5b9e000 r-xp /usr/lib/libXi.so.6.1.0
b5b9f000 b5ba1000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ba2000 b5ba8000 r-xp /usr/lib/libXtst.so.6.1.0
b5ba9000 b5bb3000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb4000 b5bbd000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bbf000 b5bc1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bc2000 b5bc7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bc8000 b5bda000 r-xp /usr/lib/libXext.so.6.4.0
b5bdb000 b5bdd000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bde000 b5be0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5be2000 b5d24000 r-xp /usr/lib/libX11.so.6.3.0
b5d28000 b5d32000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d33000 b5d49000 r-xp /usr/lib/libudev.so.1.6.0
b5d4c000 b5d50000 r-xp /lib/libattr.so.1.1.0
b5d51000 b5d80000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d82000 b5d88000 r-xp /usr/lib/libffi.so.6.0.2
b5d89000 b5dac000 r-xp /lib/libz.so.1.2.8
b5dad000 b5db0000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5db1000 b5f0d000 r-xp /usr/lib/libxml2.so.2.9.2
b5f13000 b5ffa000 r-xp /usr/lib/libstdc++.so.6.0.20
b6007000 b600a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b600b000 b602d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b602e000 b6042000 r-xp /lib/libresolv-2.20-2014.11.so
b6046000 b606a000 r-xp /usr/lib/liblzma.so.5.0.3
b606b000 b606d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b606f000 b6079000 r-xp /usr/lib/libembryo.so.1.13.0
b607a000 b60a3000 r-xp /usr/lib/libpng12.so.0.50.0
b60a4000 b60ed000 r-xp /usr/lib/libjpeg.so.8.0.2
b60fe000 b6105000 r-xp /lib/librt-2.20-2014.11.so
b6107000 b6126000 r-xp /usr/lib/libector.so.1.13.0
b6129000 b6156000 r-xp /usr/lib/liblua-5.1.so
b6157000 b61e7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61eb000 b6229000 r-xp /usr/lib/libfontconfig.so.1.8.0
b622a000 b6240000 r-xp /usr/lib/libfribidi.so.0.3.1
b6241000 b629a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b629d000 b62e8000 r-xp /lib/libm-2.20-2014.11.so
b62ea000 b62fc000 r-xp /usr/lib/libeio.so.1.13.0
b62fd000 b6300000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6301000 b6307000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6308000 b632b000 r-xp /usr/lib/libefreet.so.1.13.0
b632e000 b6359000 r-xp /usr/lib/libeldbus.so.1.13.0
b635a000 b638e000 r-xp /usr/lib/libecore_con.so.1.13.0
b6390000 b6399000 r-xp /usr/lib/libecore_imf.so.1.13.0
b639a000 b63a3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a4000 b63b7000 r-xp /usr/lib/libeo.so.1.13.0
b63b9000 b63cc000 r-xp /usr/lib/libecore_input.so.1.13.0
b63cd000 b63d4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d5000 b63f8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63f9000 b6425000 r-xp /usr/lib/libeet.so.1.13.0
b642e000 b6499000 r-xp /usr/lib/libeina.so.1.13.0
b649c000 b64b3000 r-xp /usr/lib/libefl.so.1.13.0
b64b5000 b661c000 r-xp /usr/lib/libicuuc.so.51.1
b662a000 b6836000 r-xp /usr/lib/libicui18n.so.51.1
b683e000 b688d000 r-xp /usr/lib/libecore_x.so.1.13.0
b688f000 b68a9000 r-xp /lib/libgcc_s-4.9.so.1
b68ab000 b68af000 r-xp /lib/libcap.so.2.21
b68b0000 b68f6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68f7000 b68fe000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6900000 b6952000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6954000 b6adf000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae4000 b6bb2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb5000 b6bb9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bba000 b6bc9000 r-xp /usr/lib/libvconf.so.0.2.45
b6bca000 b6bcd000 r-xp /usr/lib/libvasum.so.0.3.1
b6bce000 b6bd1000 r-xp /usr/lib/libttrace.so.1.1
b6bd3000 b6bd7000 r-xp /usr/lib/libiniparser.so.0
b6bd8000 b6c08000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c09000 b6c12000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c13000 b6c38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c39000 b6c49000 r-xp /usr/lib/libunwind.so.8.0.1
b6c53000 b6e01000 r-xp /lib/libc-2.20-2014.11.so
b6e09000 b6f4c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f4e000 b6fa6000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fa7000 b6fdb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fde000 b70b2000 r-xp /usr/lib/libedje.so.1.13.0
b70b5000 b70e1000 r-xp /usr/lib/libecore.so.1.13.0
b70f2000 b7318000 r-xp /usr/lib/libevas.so.1.13.0
b7340000 b7358000 r-xp /lib/libpthread-2.20-2014.11.so
b735c000 b76d6000 r-xp /usr/lib/libelementary.so.1.13.0
b76f6000 b76fa000 r-xp /usr/lib/libsmack.so.1.0.0
b76fb000 b7704000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7705000 b7708000 r-xp /usr/lib/libdlog.so.0.0.0
b7709000 b770e000 r-xp /usr/lib/libbundle.so.0.1.22
b770f000 b7712000 r-xp /lib/libdl-2.20-2014.11.so
b7714000 b7739000 r-xp /usr/lib/libaul.so.0.1.0
b773c000 b773e000 r-xp /usr/lib/libappsvc.so.0.1.0
b773f000 b7744000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7745000 b774c000 r-xp /usr/lib/libappcore-efl.so.1.1
b774e000 b7753000 r-xp /usr/lib/libsys-assert.so
b7756000 b7757000 r-xp [vdso]
b7757000 b7779000 r-xp /lib/ld-2.20-2014.11.so
b777b000 b7783000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7865)
Call Stack Count: 4
 0: strchrnul + 0x17 (0xb6cce9c7) [/lib/libc.so.6] + 0x7b9c7
 1: __vsnprintf_chk + 0xac (0xb6d487ac) [/lib/libc.so.6] + 0xf57ac
 2: (0xb6e04870) [/lib/libc.so.6] + 0xb6e04870
 3: ((nil)) (null)
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
1]
06-04 11:55:38.327+0900 D/BADGE   ( 2864): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-04 11:55:38.327+0900 E/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-04 11:55:38.327+0900 D/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-04 11:55:38.327+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[3, 3] pageId[100001]
06-04 11:55:38.327+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-04 11:55:38.327+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-04 11:55:38.327+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 11:55:38.327+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 11:55:38.327+0900 E/cluster-home( 2864): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-04 11:55:38.327+0900 D/BADGE   ( 2864): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-04 11:55:38.337+0900 E/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-04 11:55:38.337+0900 D/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[4, 3] pageId[100001]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 11:55:38.337+0900 E/cluster-home( 2864): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-04 11:55:38.337+0900 D/BADGE   ( 2864): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-04 11:55:38.337+0900 E/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-04 11:55:38.337+0900 D/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[1, 4] pageId[100001]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 11:55:38.337+0900 E/cluster-home( 2864): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-04 11:55:38.337+0900 D/BADGE   ( 2864): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-04 11:55:38.337+0900 E/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-04 11:55:38.337+0900 D/cluster-home( 2864): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 11:55:38.337+0900 D/cluster-view( 2864): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-04 11:55:38.457+0900 D/rpm-installer( 7969): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-04 11:55:38.457+0900 D/rpm-installer( 7969): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-04 11:55:38.457+0900 D/rpm-installer( 7969): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-04 11:55:38.457+0900 D/rpm-installer( 7969): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-04 11:55:38.457+0900 D/PKGMGR_SERVER( 7954): pkgmgr-server.c: sighandler(387) > child exit [7969]
06-04 11:55:38.457+0900 E/PKGMGR_SERVER( 7954): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7969]
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 11:55:38.957+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 11:55:38.957+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 11:55:38.957+0900 I/AUL     ( 2729): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 11:55:38.957+0900 D/AUL     ( 2729): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8022, pid = 8024
06-04 11:55:38.957+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 11:55:38.957+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 11:55:38.957+0900 I/AUL     ( 2729): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 11:55:38.957+0900 E/AUL_AMD ( 2729): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 11:55:38.957+0900 W/AUL_AMD ( 2729): amd_launch.c: _start_app(2233) > caller pid : 8024
06-04 11:55:38.957+0900 E/AUL_AMD ( 2729): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 11:55:38.957+0900 W/AUL_AMD ( 2729): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2648) > process_pool: false
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 11:55:38.957+0900 W/AUL_AMD ( 2729): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 11:55:38.957+0900 D/AUL_AMD ( 2729): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 11:55:38.957+0900 D/AUL     ( 2729): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 11:55:38.957+0900 D/RESOURCED( 2844): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 11:55:38.957+0900 D/RESOURCED( 2844): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 11:55:38.957+0900 W/AUL_PAD ( 2915): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 11:55:38.957+0900 D/AUL     ( 2915): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7865, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 11:55:38.957+0900 W/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 11:55:38.957+0900 D/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 11:55:38.957+0900 E/RESOURCED( 2844): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 11:55:38.957+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 11:55:38.957+0900 D/AUL     ( 7865): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7866) is sent.
06-04 11:55:38.957+0900 D/AUL     ( 7865): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7866, signo: 10
06-04 11:55:38.967+0900 D/AUL     ( 7865): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1NDQ5MzgvOTYyMjE5AA==##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4MDI0AA==##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 11:55:38.967+0900 D/AUL_PAD ( 7865): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 11:55:38.967+0900 I/CAPI_APPFW_APPLICATION( 7865): app_main.c: ui_app_main(788) > app_efl_main
06-04 11:55:38.967+0900 D/LAUNCH  ( 7865): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 11:55:38.967+0900 D/APP_CORE( 7865): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 11:55:38.967+0900 D/APP_CORE( 7865): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 11:55:38.967+0900 D/APP_CORE( 7865): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 11:55:38.977+0900 D/APP_CORE( 7865): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 11:55:38.977+0900 D/AUL     ( 7865): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 11:55:38.977+0900 D/APP_CORE( 7865): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42a1520
06-04 11:55:38.977+0900 D/LAUNCH  ( 7865): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 11:55:38.977+0900 I/CAPI_APPFW_APPLICATION( 7865): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 11:55:39.007+0900 D/LAUNCH  ( 7865): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 11:55:39.007+0900 D/APP_CORE( 7865): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 11:55:39.007+0900 E/E17     ( 2748): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02a00002)
06-04 11:55:39.017+0900 E/E17     ( 2748): e_border.c: e_border_show(2088) > BD_SHOW(0x02a00002)
06-04 11:55:39.027+0900 W/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7865
06-04 11:55:39.027+0900 E/EFL     ( 2748): eo<2748> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 11:55:39.027+0900 E/EFL     ( 2748): eo<2748> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 11:55:39.027+0900 D/APP_CORE( 7865): appcore.c: __aul_handler(587) > [APP 7865]     AUL event: AUL_START
06-04 11:55:39.027+0900 I/APP_CORE( 7865): appcore-efl.c: __do_app(496) > [APP 7865] Event: RESET State: CREATED
06-04 11:55:39.027+0900 D/APP_CORE( 7865): appcore-efl.c: __do_app(527) > [APP 7865] RESET
06-04 11:55:39.027+0900 D/LAUNCH  ( 7865): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 11:55:39.027+0900 D/APP_CORE( 7865): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 11:55:39.027+0900 D/APP_CORE( 7865): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 11:55:39.027+0900 I/CAPI_APPFW_APPLICATION( 7865): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 11:55:39.027+0900 D/AUL     ( 7865): service.c: __set_bundle(186) > __set_bundle
06-04 11:55:39.027+0900 D/LAUNCH  ( 7865): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 11:55:39.027+0900 D/APP_CORE( 7865): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 11:55:39.027+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 11:55:39.027+0900 E/EFL     ( 7865): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 11:55:39.027+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 11:55:39.027+0900 E/EFL     ( 7865): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 11:55:39.027+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 11:55:39.027+0900 E/EFL     ( 7865): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 11:55:39.027+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 11:55:39.027+0900 E/EFL     ( 7865): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 11:55:39.027+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 11:55:39.027+0900 E/EFL     ( 7865): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 11:55:39.027+0900 D/INDICATOR( 2851): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 11:55:39.027+0900 D/INDICATOR( 2851): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 11:55:39.037+0900 D/INDICATOR( 2851): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 11:55:39.037+0900 D/INDICATOR( 2851): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 11:55:39.037+0900 D/INDICATOR( 2851): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 11:55:39.037+0900 D/INDICATOR( 2851): main.c: _rotate_window(252) > port :: hide more icon
06-04 11:55:39.047+0900 W/APP_CORE( 7865): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
06-04 11:55:39.047+0900 D/APP_CORE( 7865): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2a00002
06-04 11:55:39.047+0900 D/APP_CORE( 7865): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 11:55:39.047+0900 D/AUL     ( 7865): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 11:55:39.057+0900 D/AUL_PAD ( 2915): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 11:55:39.057+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7865, appid: org.example.example
06-04 11:55:39.057+0900 D/AUL     ( 2729): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 11:55:39.057+0900 E/AUL     ( 2729): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 11:55:39.057+0900 D/AUL_AMD ( 2729): amd_launch.c: _start_app(2700) > add app group info
06-04 11:55:39.057+0900 E/AUL     ( 2729): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 11:55:39.057+0900 D/AUL_AMD ( 2729): amd_status.c: _status_add_app_info_list(427) > pid(7865) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 11:55:39.057+0900 D/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(442) > pid(7696)
06-04 11:55:39.057+0900 W/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 11:55:39.057+0900 D/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(442) > pid(7696)
06-04 11:55:39.057+0900 W/AUL_AMD ( 2729): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 11:55:39.057+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 11:55:39.057+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 11:55:39.067+0900 D/PKGMGR_INFO( 2729): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 11:55:39.067+0900 D/AUL_AMD ( 2729): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7865 is org.example.example
06-04 11:55:39.067+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7865 : 0
06-04 11:55:39.067+0900 D/AUL     ( 2939): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 11:55:39.067+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 7865
06-04 11:55:39.067+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 11:55:39.067+0900 E/RESOURCED( 2844): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 11:55:39.067+0900 D/AUL_AMD ( 2729): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 11:55:39.067+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(888) > available memory = 311
06-04 11:55:39.297+0900 D/APP_CORE( 7865): appcore.c: __prt_ltime(236) > [APP 7865] first idle after reset: 348 msec
06-04 11:55:39.347+0900 E/E17     ( 2748): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 11:55:39.347+0900 D/APP_CORE( 2864): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 11:55:39.347+0900 D/APP_CORE( 2864): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 11:55:39.347+0900 D/APP_CORE( 2864): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 11:55:39.347+0900 I/APP_CORE( 2864): appcore-efl.c: __do_app(496) > [APP 2864] Event: PAUSE State: RUNNING
06-04 11:55:39.347+0900 D/APP_CORE( 2864): appcore-efl.c: __do_app(565) > [APP 2864] PAUSE
06-04 11:55:39.347+0900 I/CAPI_APPFW_APPLICATION( 2864): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 11:55:39.347+0900 E/cluster-home( 2864): homescreen.cpp: OnPause(84) >  app pause
06-04 11:55:39.347+0900 D/cluster-view( 2864): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 11:55:39.347+0900 D/cluster-view( 2864): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 11:55:39.347+0900 D/APP_CORE( 2864): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 11:55:39.347+0900 E/APP_CORE( 2864): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(456) > pid(2864) status(4)
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(468) > pid(2864) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 11:55:39.347+0900 D/AUL     ( 2729): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 11:55:39.347+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2864, appid: org.tizen.homescreen, status: bg
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2891) > pid(7865) status(3)
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 11:55:39.347+0900 W/AUL_AMD ( 2729): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 11:55:39.347+0900 W/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(456) > pid(7865) status(3)
06-04 11:55:39.347+0900 D/AUL_AMD ( 2729): amd_status.c: _status_update_app_info_list(468) > pid(7865) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 11:55:39.347+0900 D/AUL     ( 2729): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 11:55:39.347+0900 W/AUL     ( 2729): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7865, appid: org.example.example, status: fg
06-04 11:55:39.347+0900 D/RESOURCED( 2844): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7865
06-04 11:55:39.347+0900 D/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7865, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 11:55:39.347+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7865
06-04 11:55:39.357+0900 D/DATA_PROVIDER_MASTER( 2917): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2864 is paused
06-04 11:55:39.357+0900 D/DATA_PROVIDER_MASTER( 2917): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 11:55:39.357+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 11:55:39.357+0900 I/CAPI_WIDGET_APPLICATION( 2999): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 11:55:39.357+0900 W/AUL     ( 2999): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2999, appid: org.tizen.calendar.widget, status: bg
06-04 11:55:39.387+0900 D/RESOURCED( 2844): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7865, appname = org.example.example, pkgname = org.example.example
06-04 11:55:39.387+0900 D/RESOURCED( 2844): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7865, appname = org.example.example
06-04 11:55:39.387+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7865
06-04 11:55:39.387+0900 D/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2999, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 11:55:39.387+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2999
06-04 11:55:39.387+0900 D/RESOURCED( 2844): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2999, appname = org.tizen.calendar.widget
06-04 11:55:39.387+0900 D/RESOURCED( 2844): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2999
06-04 11:55:39.387+0900 I/RESOURCED( 2844): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 11:55:39.387+0900 I/RESOURCED( 2844): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 0
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 11:55:39.417+0900 I/APP_CORE( 7865): appcore-efl.c: __do_app(496) > [APP 7865] Event: RESUME State: CREATED
06-04 11:55:39.417+0900 D/LAUNCH  ( 7865): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __do_app(607) > [APP 7865] RESUME
06-04 11:55:39.417+0900 I/APP_CORE( 7865): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 11:55:39.417+0900 I/APP_CORE( 7865): appcore-efl.c: __do_app(614) > [APP 7865] Initial Launching, call the resume_cb
06-04 11:55:39.417+0900 I/CAPI_APPFW_APPLICATION( 7865): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 11:55:39.417+0900 D/LAUNCH  ( 7865): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 11:55:39.417+0900 D/LAUNCH  ( 7865): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 11:55:39.417+0900 D/APP_CORE( 7865): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 11:55:39.417+0900 E/APP_CORE( 7865): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 11:55:39.467+0900 D/AUL_AMD ( 2729): amd_launch.c: __e17_status_handler(2910) > pid(7865) status(0)
06-04 11:55:39.997+0900 E/PKGMGR_SERVER( 7954): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 11:55:39.997+0900 E/PKGMGR_SERVER( 7954): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 11:55:40.067+0900 D/AUL_PAD ( 2915): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 11:55:40.067+0900 D/AUL_PAD ( 8032): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 11:55:40.067+0900 D/AUL_PAD ( 2915): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 11:55:40.067+0900 E/RESOURCED( 2844): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.635
06-04 11:55:40.567+0900 D/AUL_AMD ( 2729): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 11:55:40.567+0900 D/RUA     ( 2729): rua.c: rua_add_history(179) > rua_add_history start
06-04 11:55:40.567+0900 D/RUA     ( 2729): rua.c: rua_add_history(247) > rua_add_history ok
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7c6b760
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(69) > get pre-initialization function
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(73) > get shutdown function
06-04 11:55:41.087+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7c6ba40
06-04 11:55:41.097+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7c6d640
06-04 11:55:41.097+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(69) > get pre-initialization function
06-04 11:55:41.097+0900 D/AUL_PAD ( 8032): preload.h: __preload_init(73) > get shutdown function
06-04 11:55:41.097+0900 D/AUL_PAD ( 8032): preexec.h: __preexec_init(76) > preexec start
06-04 11:55:41.097+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 11:55:41.097+0900 D/AUL     ( 8032): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 11:55:41.097+0900 D/AUL     ( 8032): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 11:55:41.097+0900 D/AUL     ( 8032): process_pool.c: __connect_to_launchpad(132) > send(8032) : 4
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 11:55:41.097+0900 D/AUL_PAD ( 2915): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8032
06-04 11:55:41.097+0900 D/AUL     ( 8032): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 11:55:41.157+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 11:55:41.167+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 11:55:41.167+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 11:55:41.167+0900 D/AUL_PAD ( 8032): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 11:55:44.347+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 11:55:44.347+0900 I/APP_CORE( 2864): appcore-efl.c: __do_app(496) > [APP 2864] Event: MEM_FLUSH State: PAUSED
06-04 11:55:44.347+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 11:55:44.347+0900 D/APP_CORE( 2864): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2864
06-04 11:55:44.347+0900 D/APP_CORE( 2864): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 11:55:44.357+0900 D/RESOURCED( 2844): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2864
06-04 11:55:44.607+0900 E/CAPI_NETWORK_WIFI( 2851): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 11:55:44.607+0900 E/INDICATOR( 2851): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001b8dd)
06-04 11:55:44.607+0900 E/INDICATOR( 2851): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 11:55:44.607+0900 E/INDICATOR( 2851): 
06-04 11:55:55.827+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601a7d 
06-04 11:55:56.827+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
06-04 11:55:56.897+0900 D/RESOURCED( 2844): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 11:55:56.897+0900 I/RESOURCED( 2844): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 11:55:56.897+0900 D/RESOURCED( 2844): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 11:55:56.897+0900 I/RESOURCED( 2844): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 11:55:56.937+0900 I/user_tag0( 7865): /opt/usr/apps/org.example.example/data/feeding.db
06-04 11:55:56.947+0900 I/tag     ( 7865): eonji~
06-04 11:55:57.027+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601a7d 
06-04 11:55:57.946+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601a7d 
06-04 11:55:58.046+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.056+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.106+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.106+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.106+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:58.106+0900 D/IMMODULE( 7865): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 11:55:58.106+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 11:55:58.106+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.116+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 11:55:58.116+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.136+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 11:55:58.136+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.136+0900 D/ISF_QUERY( 7865): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.146+0900 D/IMMODULE( 7865): scim_panel_client.cpp: open_connection(162) > 
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(515) > ppid:2915  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 11:55:58.146+0900 D/ISF_SOCKET( 7865): scim_socket.cpp: connect(524) > connect() succeeded
06-04 11:55:58.156+0900 D/IMMODULE( 7865): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 11:55:58.906+0900 D/PROCESSMGR( 2748): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601a7d 
06-04 11:55:59.086+0900 I/tag     ( 7865): insert
06-04 11:55:59.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:59.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:59.096+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:59.106+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:59.106+0900 E/EFL     ( 7865): edje<7865> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 11:55:59.136+0900 W/CRASH_MANAGER( 8035): worker.c: worker_job(1204) > 1107865657861149654495
