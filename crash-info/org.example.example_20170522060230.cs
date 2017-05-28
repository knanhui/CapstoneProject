S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12391
Date: 2017-05-22 06:02:30+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x8000aa56
ebp = 0xbfcd91b8, esp = 0xbfcd90a0
eax = 0x8000aa56, ebx = 0xb379d000
ecx = 0x00000040, edx = 0xbfcd91a0
eip = 0xb3798728

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         7 KB
Cached:     168928 KB
VmPeak:     122248 KB
VmSize:     122248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35792 KB
VmRSS:       35792 KB
VmData:      53248 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33744 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12391 TID = 12391
12391 12392 12572 12573 12578 

Maps Information
b0e93000 b0e9a000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0e9b000 b0eb3000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1907000 b190e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b190f000 b1913000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2c3c000 b2c46000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c4c000 b2c58000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c59000 b2c7a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c7f000 b2c80000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c81000 b2c86000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c87000 b2c89000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c8a000 b2c8c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c8d000 b2c99000 r-xp /usr/lib/libdrm.so.2.4.0
b2c9a000 b2ca4000 r-xp /usr/lib/libtbm.so.1.0.0
b2ca5000 b2cba000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cbb000 b2ccd000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34cf000 b34d8000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34d9000 b34e2000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34e3000 b34f5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f6000 b3517000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b351e000 b351f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3520000 b3521000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3522000 b3525000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3526000 b3529000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3631000 b3637000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3638000 b377c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b378c000 b378d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b378e000 b3791000 r-xp /usr/lib/libdri2.so.0.0.0
b3792000 b3793000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3794000 b379c000 r-xp /opt/usr/apps/org.example.example/bin/example
b379e000 b37d7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41da000 b41e5000 r-xp /lib/libnss_files-2.20-2014.11.so
b41e7000 b41f2000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f4000 b420b000 r-xp /lib/libnsl-2.20-2014.11.so
b420f000 b4217000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4219000 b423d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b423e000 b423f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4240000 b4243000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4244000 b424b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b424c000 b4256000 r-xp /usr/lib/libsensord-share.so
b4257000 b4273000 r-xp /usr/lib/libsensor.so.1.2.0
b4275000 b427e000 r-xp /usr/lib/libappcore-common.so.1.1
b4281000 b4283000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4298000 b429a000 r-xp /usr/lib/libXau.so.6.0.0
b429b000 b42bd000 r-xp /usr/lib/libxcb.so.1.1.0
b42bf000 b42c8000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f1000 b42f3000 r-xp /usr/lib/libiri.so
b42f4000 b431a000 r-xp /lib/libexpat.so.1.5.2
b431c000 b4387000 r-xp /usr/lib/libssl.so.1.0.0
b438d000 b4399000 r-xp /usr/lib/libethumb.so.1.13.0
b439a000 b439e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b439f000 b45f0000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b6b000 b5b7b000 r-xp /usr/lib/libXi.so.6.1.0
b5b7c000 b5b7e000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b7f000 b5b85000 r-xp /usr/lib/libXtst.so.6.1.0
b5b86000 b5b90000 r-xp /usr/lib/libXrender.so.1.3.0
b5b91000 b5b9a000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b9c000 b5b9e000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b9f000 b5ba4000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba5000 b5bb7000 r-xp /usr/lib/libXext.so.6.4.0
b5bb8000 b5bba000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bbf000 b5d01000 r-xp /usr/lib/libX11.so.6.3.0
b5d05000 b5d0f000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d10000 b5d26000 r-xp /usr/lib/libudev.so.1.6.0
b5d29000 b5d2d000 r-xp /lib/libattr.so.1.1.0
b5d2e000 b5d5d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d5f000 b5d65000 r-xp /usr/lib/libffi.so.6.0.2
b5d66000 b5d89000 r-xp /lib/libz.so.1.2.8
b5d8a000 b5d8d000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8e000 b5eea000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef0000 b5fd7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe4000 b5fe7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe8000 b600a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b600b000 b601f000 r-xp /lib/libresolv-2.20-2014.11.so
b6023000 b6047000 r-xp /usr/lib/liblzma.so.5.0.3
b6048000 b604a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b604c000 b6056000 r-xp /usr/lib/libembryo.so.1.13.0
b6057000 b6080000 r-xp /usr/lib/libpng12.so.0.50.0
b6081000 b60ca000 r-xp /usr/lib/libjpeg.so.8.0.2
b60db000 b60e2000 r-xp /lib/librt-2.20-2014.11.so
b60e4000 b6103000 r-xp /usr/lib/libector.so.1.13.0
b6106000 b6133000 r-xp /usr/lib/liblua-5.1.so
b6134000 b61c4000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c8000 b6206000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6207000 b621d000 r-xp /usr/lib/libfribidi.so.0.3.1
b621e000 b6277000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b627a000 b62c5000 r-xp /lib/libm-2.20-2014.11.so
b62c7000 b62d9000 r-xp /usr/lib/libeio.so.1.13.0
b62da000 b62dd000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62de000 b62e4000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e5000 b6308000 r-xp /usr/lib/libefreet.so.1.13.0
b630b000 b6336000 r-xp /usr/lib/libeldbus.so.1.13.0
b6337000 b636b000 r-xp /usr/lib/libecore_con.so.1.13.0
b636d000 b6376000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6377000 b6380000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6381000 b6394000 r-xp /usr/lib/libeo.so.1.13.0
b6396000 b63a9000 r-xp /usr/lib/libecore_input.so.1.13.0
b63aa000 b63b1000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b2000 b63d5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d6000 b6402000 r-xp /usr/lib/libeet.so.1.13.0
b640b000 b6476000 r-xp /usr/lib/libeina.so.1.13.0
b6479000 b6490000 r-xp /usr/lib/libefl.so.1.13.0
b6492000 b65f9000 r-xp /usr/lib/libicuuc.so.51.1
b6607000 b6813000 r-xp /usr/lib/libicui18n.so.51.1
b681b000 b686a000 r-xp /usr/lib/libecore_x.so.1.13.0
b686c000 b6886000 r-xp /lib/libgcc_s-4.9.so.1
b6888000 b688c000 r-xp /lib/libcap.so.2.21
b688d000 b68d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d4000 b68db000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68dd000 b692f000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6931000 b6abc000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac1000 b6b8f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b92000 b6b96000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b97000 b6ba6000 r-xp /usr/lib/libvconf.so.0.2.45
b6ba7000 b6baa000 r-xp /usr/lib/libvasum.so.0.3.1
b6bab000 b6bae000 r-xp /usr/lib/libttrace.so.1.1
b6bb0000 b6bb4000 r-xp /usr/lib/libiniparser.so.0
b6bb5000 b6be5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be6000 b6bef000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf0000 b6c15000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c16000 b6c26000 r-xp /usr/lib/libunwind.so.8.0.1
b6c30000 b6dde000 r-xp /lib/libc-2.20-2014.11.so
b6de6000 b6f29000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f2b000 b6f83000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f84000 b6fb8000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fbb000 b708f000 r-xp /usr/lib/libedje.so.1.13.0
b7092000 b70be000 r-xp /usr/lib/libecore.so.1.13.0
b70cf000 b72f5000 r-xp /usr/lib/libevas.so.1.13.0
b731d000 b7335000 r-xp /lib/libpthread-2.20-2014.11.so
b7339000 b76b3000 r-xp /usr/lib/libelementary.so.1.13.0
b76d3000 b76d7000 r-xp /usr/lib/libsmack.so.1.0.0
b76d8000 b76e1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e2000 b76e5000 r-xp /usr/lib/libdlog.so.0.0.0
b76e6000 b76eb000 r-xp /usr/lib/libbundle.so.0.1.22
b76ec000 b76ef000 r-xp /lib/libdl-2.20-2014.11.so
b76f1000 b7716000 r-xp /usr/lib/libaul.so.0.1.0
b7719000 b771b000 r-xp /usr/lib/libappsvc.so.0.1.0
b771c000 b7721000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7722000 b7729000 r-xp /usr/lib/libappcore-efl.so.1.1
b772b000 b7730000 r-xp /usr/lib/libsys-assert.so
b7733000 b7734000 r-xp [vdso]
b7734000 b7756000 r-xp /lib/ld-2.20-2014.11.so
b7758000 b7760000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12391)
Call Stack Count: 21
 0: popup_set_btn_clicked_cb + 0x78 (0xb3798728) [/opt/usr/apps/org.example.example/bin/example] + 0x4728
 1: (0xb7158116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb638f319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb638cd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb715a9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb740b404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb703ef39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7045a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb703ffdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70404cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb704068f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70a5702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb709f055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70a81b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70a8587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb750122d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7725dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb771ec80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb3798f8e) [/opt/usr/apps/org.example.example/bin/example] + 0x4f8e
19: create_time + 0x58 (0xb775a148) [/opt/usr/apps/org.example.example/bin/example] + 0xb775a148
20: __libc_start_main + 0xde (0xb6c47e4e) [/lib/libc.so.6] + 0x17e4e
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
 IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 06:02:08.423+0900 D/AUL_AMD ( 2774): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12391 is org.example.example
05-22 06:02:08.423+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12391 : 0
05-22 06:02:08.433+0900 D/AUL     ( 3004): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 06:02:08.443+0900 D/INDICATOR( 2882): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-22 06:02:08.443+0900 D/INDICATOR( 2882): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 06:02:08.453+0900 D/INDICATOR( 2882): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 06:02:08.453+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 06:02:08.453+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 06:02:08.453+0900 D/INDICATOR( 2882): main.c: _rotate_window(252) > port :: hide more icon
05-22 06:02:08.463+0900 D/APP_CORE(12391): appcore.c: __prt_ltime(236) > [APP 12391] first idle after reset: 417 msec
05-22 06:02:08.463+0900 W/APP_CORE(12391): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2200002
05-22 06:02:08.463+0900 D/APP_CORE(12391): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2200002
05-22 06:02:08.463+0900 D/APP_CORE(12391): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-22 06:02:08.463+0900 D/AUL     (12391): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-22 06:02:08.473+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 34
05-22 06:02:08.863+0900 E/E17     ( 2775): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-22 06:02:08.863+0900 D/APP_CORE( 2900): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-22 06:02:08.863+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-22 06:02:08.863+0900 D/APP_CORE( 2900): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-22 06:02:08.863+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: PAUSE State: RUNNING
05-22 06:02:08.863+0900 D/APP_CORE( 2900): appcore-efl.c: __do_app(565) > [APP 2900] PAUSE
05-22 06:02:08.863+0900 I/CAPI_APPFW_APPLICATION( 2900): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-22 06:02:08.863+0900 E/cluster-home( 2900): homescreen.cpp: OnPause(84) >  app pause
05-22 06:02:08.863+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-22 06:02:08.863+0900 D/cluster-view( 2900): homescreen-view-manager.cpp: AppPause(923) >  END
05-22 06:02:08.863+0900 D/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:02:08.863+0900 E/APP_CORE( 2900): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2200002 fully_obscured 0
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 06:02:08.863+0900 I/APP_CORE(12391): appcore-efl.c: __do_app(496) > [APP 12391] Event: RESUME State: CREATED
05-22 06:02:08.863+0900 D/LAUNCH  (12391): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 06:02:08.863+0900 D/APP_CORE(12391): appcore-efl.c: __do_app(607) > [APP 12391] RESUME
05-22 06:02:08.873+0900 I/APP_CORE(12391): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 06:02:08.873+0900 I/APP_CORE(12391): appcore-efl.c: __do_app(614) > [APP 12391] Initial Launching, call the resume_cb
05-22 06:02:08.873+0900 I/CAPI_APPFW_APPLICATION(12391): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 06:02:08.873+0900 D/LAUNCH  (12391): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 06:02:08.873+0900 D/LAUNCH  (12391): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 06:02:08.873+0900 D/APP_CORE(12391): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 06:02:08.873+0900 E/APP_CORE(12391): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 06:02:08.883+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(2900) status(4)
05-22 06:02:08.883+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(2900) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-22 06:02:08.883+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-22 06:02:08.883+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2900, appid: org.tizen.homescreen, status: bg
05-22 06:02:08.883+0900 D/DATA_PROVIDER_MASTER( 2965): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2900 is paused
05-22 06:02:08.883+0900 D/DATA_PROVIDER_MASTER( 2965): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 06:02:08.893+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-22 06:02:08.893+0900 I/CAPI_WIDGET_APPLICATION( 3012): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-22 06:02:08.893+0900 W/AUL     ( 3012): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3012, appid: org.tizen.calendar.widget, status: bg
05-22 06:02:08.913+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3012, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-22 06:02:08.913+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3012
05-22 06:02:08.913+0900 D/RESOURCED( 2878): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3012, appname = org.tizen.calendar.widget
05-22 06:02:08.913+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3012
05-22 06:02:08.913+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(12391) status(3)
05-22 06:02:08.913+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 06:02:08.913+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 06:02:08.913+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 06:02:08.913+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(12391) status(3)
05-22 06:02:08.913+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(12391) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 06:02:08.913+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 06:02:08.913+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12391, appid: org.example.example, status: fg
05-22 06:02:08.933+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12391
05-22 06:02:08.933+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12391, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 06:02:08.933+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12391
05-22 06:02:08.963+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12391, appname = org.example.example, pkgname = org.example.example
05-22 06:02:08.963+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12391, appname = org.example.example
05-22 06:02:08.963+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12391
05-22 06:02:08.963+0900 I/RESOURCED( 2878): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 06:02:08.963+0900 I/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 06:02:08.993+0900 E/PKGMGR_SERVER(12427): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-22 06:02:08.993+0900 E/PKGMGR_SERVER(12427): pkgmgr-server.c: main(2265) > package manager server terminated.
05-22 06:02:08.993+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2910) > pid(12391) status(0)
05-22 06:02:09.173+0900 D/AUL_PAD ( 2961): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-22 06:02:09.183+0900 D/AUL_PAD (12576): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-22 06:02:09.263+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-22 06:02:09.623+0900 D/AUL_AMD ( 2774): amd_status.c: __app_terminate_timer_cb(442) > pid(12202)
05-22 06:02:09.623+0900 W/AUL_AMD ( 2774): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-22 06:02:09.623+0900 D/AUL_AMD ( 2774): amd_status.c: __app_terminate_timer_cb(442) > pid(12202)
05-22 06:02:09.623+0900 W/AUL_AMD ( 2774): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-22 06:02:09.673+0900 D/AUL_AMD ( 2774): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-22 06:02:09.673+0900 D/RUA     ( 2774): rua.c: rua_add_history(179) > rua_add_history start
05-22 06:02:09.763+0900 D/RUA     ( 2774): rua.c: rua_add_history(247) > rua_add_history ok
05-22 06:02:10.303+0900 D/AUL_PAD (12576): launchpad_loader.c: main(588) > sleeping 1 sec...
05-22 06:02:10.303+0900 D/AUL_PAD (12576): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-22 06:02:10.313+0900 D/AUL_PAD (12576): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7cb9760
05-22 06:02:10.313+0900 D/AUL_PAD (12576): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:02:10.313+0900 D/AUL_PAD (12576): preload.h: __preload_init(73) > get shutdown function
05-22 06:02:10.313+0900 D/AUL_PAD (12576): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7cb9a40
05-22 06:02:10.333+0900 D/AUL_PAD (12576): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7cbb640
05-22 06:02:10.333+0900 D/AUL_PAD (12576): preload.h: __preload_init(69) > get pre-initialization function
05-22 06:02:10.333+0900 D/AUL_PAD (12576): preload.h: __preload_init(73) > get shutdown function
05-22 06:02:10.333+0900 D/AUL_PAD (12576): preexec.h: __preexec_init(76) > preexec start
05-22 06:02:10.333+0900 D/AUL_PAD (12576): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-22 06:02:10.373+0900 D/AUL     (12576): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-22 06:02:10.373+0900 D/AUL     (12576): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-22 06:02:10.373+0900 D/AUL     (12576): process_pool.c: __connect_to_launchpad(132) > send(12576) : 4
05-22 06:02:10.373+0900 D/AUL     (12576): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-22 06:02:10.373+0900 D/AUL_PAD ( 2961): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12576
05-22 06:02:10.433+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.850
05-22 06:02:10.773+0900 D/AUL_PAD (12576): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-22 06:02:10.783+0900 D/AUL_PAD (12576): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-22 06:02:10.783+0900 D/AUL_PAD (12576): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-22 06:02:10.783+0900 D/AUL_PAD (12576): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-22 06:02:13.873+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-22 06:02:13.873+0900 I/APP_CORE( 2900): appcore-efl.c: __do_app(496) > [APP 2900] Event: MEM_FLUSH State: PAUSED
05-22 06:02:13.873+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-22 06:02:13.873+0900 D/APP_CORE( 2900): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2900
05-22 06:02:13.873+0900 D/APP_CORE( 2900): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-22 06:02:13.883+0900 D/RESOURCED( 2878): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2900
05-22 06:02:15.353+0900 E/CAPI_NETWORK_WIFI( 2882): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-22 06:02:15.353+0900 E/INDICATOR( 2882): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
05-22 06:02:15.353+0900 E/INDICATOR( 2882): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-22 06:02:15.353+0900 E/INDICATOR( 2882): 
05-22 06:02:24.513+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401662 
05-22 06:02:25.523+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2200002
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.703+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.713+0900 E/EFL     (12391): evas_main<12391> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x8003a7d4 is not stable during recalc loop
05-22 06:02:25.723+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401662 
05-22 06:02:27.232+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401662 
05-22 06:02:27.302+0900 E/EFL     (12391): edje<12391> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-22 06:02:27.302+0900 E/EFL     (12391): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:02:27.732+0900 E/EFL     (12391): edje<12391> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 06:02:27.742+0900 E/EFL     (12391): edje<12391> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 06:02:27.762+0900 D/IMMODULE(12391): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-22 06:02:27.762+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:02:27.762+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.772+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:02:27.772+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.832+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:02:27.832+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.842+0900 D/ISF_QUERY(12391): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-22 06:02:27.852+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-socket-frontend, example
05-22 06:02:27.852+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.862+0900 D/IMMODULE(12391): scim_panel_client.cpp: open_connection(162) > 
05-22 06:02:27.862+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-panel-socket:0, example
05-22 06:02:27.862+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.862+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(515) > ppid:2961  trying connect() to local:/tmp/scim-panel-socket:0, example
05-22 06:02:27.862+0900 D/ISF_SOCKET(12391): scim_socket.cpp: connect(524) > connect() succeeded
05-22 06:02:27.882+0900 D/IMMODULE(12391): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-22 06:02:29.872+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x401662 
05-22 06:02:30.052+0900 E/EFL     (12391): edje<12391> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-22 06:02:30.052+0900 E/EFL     (12391): By the power of Grayskull, your previous Embryo stack is now broken!
05-22 06:02:30.582+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x401662 bd->visible=1
05-22 06:02:30.622+0900 W/CRASH_MANAGER(12579): worker.c: worker_job(1204) > 1112391657861149540055
