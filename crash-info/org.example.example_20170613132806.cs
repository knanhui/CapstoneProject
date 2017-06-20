S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 3341
Date: 2017-06-13 13:28:06+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb87388a8
ebp = 0xbffdd638, esp = 0xbffdd5d0
eax = 0xb87388a8, ebx = 0xb6bce0d4
ecx = 0xb37db000, edx = 0x00000000
eip = 0xb6bac1f6

Memory Information
MemTotal:      123 KB
MemFree:        31 KB
Buffers:         6 KB
Cached:     164592 KB
VmPeak:     110816 KB
VmSize:     110816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24392 KB
VmRSS:       24392 KB
VmData:      43088 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3341 TID = 3341
3341 3356 3553 3555 

Maps Information
b2b6c000 b2b76000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b7c000 b2b88000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b89000 b2baa000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2baf000 b2bb0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bb1000 b2bb6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bb7000 b2bb8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bb9000 b2bbb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bbc000 b2bbe000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bbf000 b2bcb000 r-xp /usr/lib/libdrm.so.2.4.0
b2bcc000 b2bcf000 r-xp /usr/lib/libdri2.so.0.0.0
b2bd0000 b2bda000 r-xp /usr/lib/libtbm.so.1.0.0
b2bdb000 b2bdc000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2bdd000 b2bf2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bf3000 b2c05000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3407000 b3438000 r-xp /usr/lib/libidn.so.11.5.44
b3439000 b345b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b345c000 b346c000 r-xp /usr/lib/libcares.so.2.1.0
b346d000 b3476000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3477000 b347d000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b347e000 b3494000 r-xp /usr/lib/libalarm.so.0.0.0
b3496000 b349f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34a0000 b3517000 r-xp /usr/lib/libcurl.so.4.3.0
b3519000 b352b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b352c000 b352f000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b3530000 b3533000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b3534000 b3555000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b355c000 b355d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b355e000 b355f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3560000 b3563000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3564000 b3567000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b366f000 b3675000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3676000 b37ba000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37ca000 b37d9000 r-xp /opt/usr/apps/org.example.example/bin/example
b37dc000 b3815000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4218000 b4223000 r-xp /lib/libnss_files-2.20-2014.11.so
b4225000 b4230000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4232000 b4249000 r-xp /lib/libnsl-2.20-2014.11.so
b424d000 b4255000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4257000 b427b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427c000 b427d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b427e000 b4281000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4282000 b4289000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b428a000 b4294000 r-xp /usr/lib/libsensord-share.so
b4295000 b42b1000 r-xp /usr/lib/libsensor.so.1.2.0
b42b3000 b42bc000 r-xp /usr/lib/libappcore-common.so.1.1
b42bf000 b42c1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d6000 b42d8000 r-xp /usr/lib/libXau.so.6.0.0
b42d9000 b42fb000 r-xp /usr/lib/libxcb.so.1.1.0
b42fd000 b4306000 r-xp /lib/libcrypt-2.20-2014.11.so
b432f000 b4331000 r-xp /usr/lib/libiri.so
b4332000 b4358000 r-xp /lib/libexpat.so.1.5.2
b435a000 b43c5000 r-xp /usr/lib/libssl.so.1.0.0
b43cb000 b43d7000 r-xp /usr/lib/libethumb.so.1.13.0
b43d8000 b43dc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43dd000 b462e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ba9000 b5bb9000 r-xp /usr/lib/libXi.so.6.1.0
b5bba000 b5bbc000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbd000 b5bc3000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc4000 b5bce000 r-xp /usr/lib/libXrender.so.1.3.0
b5bcf000 b5bd8000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bda000 b5bdc000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bdd000 b5be2000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be3000 b5bf5000 r-xp /usr/lib/libXext.so.6.4.0
b5bf6000 b5bf8000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bf9000 b5bfb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bfd000 b5d3f000 r-xp /usr/lib/libX11.so.6.3.0
b5d43000 b5d4d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d4e000 b5d64000 r-xp /usr/lib/libudev.so.1.6.0
b5d67000 b5d6b000 r-xp /lib/libattr.so.1.1.0
b5d6c000 b5d9b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9d000 b5da3000 r-xp /usr/lib/libffi.so.6.0.2
b5da4000 b5dc7000 r-xp /lib/libz.so.1.2.8
b5dc8000 b5dcb000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dcc000 b5f28000 r-xp /usr/lib/libxml2.so.2.9.2
b5f2e000 b6015000 r-xp /usr/lib/libstdc++.so.6.0.20
b6022000 b6025000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6026000 b6048000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6049000 b605d000 r-xp /lib/libresolv-2.20-2014.11.so
b6061000 b6085000 r-xp /usr/lib/liblzma.so.5.0.3
b6086000 b6088000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b608a000 b6094000 r-xp /usr/lib/libembryo.so.1.13.0
b6095000 b60be000 r-xp /usr/lib/libpng12.so.0.50.0
b60bf000 b6108000 r-xp /usr/lib/libjpeg.so.8.0.2
b6119000 b6120000 r-xp /lib/librt-2.20-2014.11.so
b6122000 b6141000 r-xp /usr/lib/libector.so.1.13.0
b6144000 b6171000 r-xp /usr/lib/liblua-5.1.so
b6172000 b6202000 r-xp /usr/lib/libfreetype.so.6.11.3
b6206000 b6244000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6245000 b625b000 r-xp /usr/lib/libfribidi.so.0.3.1
b625c000 b62b5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b8000 b6303000 r-xp /lib/libm-2.20-2014.11.so
b6305000 b6317000 r-xp /usr/lib/libeio.so.1.13.0
b6318000 b631b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631c000 b6322000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6323000 b6346000 r-xp /usr/lib/libefreet.so.1.13.0
b6349000 b6374000 r-xp /usr/lib/libeldbus.so.1.13.0
b6375000 b63a9000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ab000 b63b4000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b5000 b63be000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63bf000 b63d2000 r-xp /usr/lib/libeo.so.1.13.0
b63d4000 b63e7000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e8000 b63ef000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f0000 b6413000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6414000 b6440000 r-xp /usr/lib/libeet.so.1.13.0
b6449000 b64b4000 r-xp /usr/lib/libeina.so.1.13.0
b64b7000 b64ce000 r-xp /usr/lib/libefl.so.1.13.0
b64d0000 b6637000 r-xp /usr/lib/libicuuc.so.51.1
b6645000 b6851000 r-xp /usr/lib/libicui18n.so.51.1
b6859000 b68a8000 r-xp /usr/lib/libecore_x.so.1.13.0
b68aa000 b68c4000 r-xp /lib/libgcc_s-4.9.so.1
b68c6000 b68ca000 r-xp /lib/libcap.so.2.21
b68cb000 b6911000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6912000 b6919000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b691b000 b696d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b696f000 b6afa000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aff000 b6bcd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd0000 b6bd4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd5000 b6be4000 r-xp /usr/lib/libvconf.so.0.2.45
b6be5000 b6be8000 r-xp /usr/lib/libvasum.so.0.3.1
b6be9000 b6bec000 r-xp /usr/lib/libttrace.so.1.1
b6bee000 b6bf2000 r-xp /usr/lib/libiniparser.so.0
b6bf3000 b6c23000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c24000 b6c2d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c2e000 b6c53000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c54000 b6c64000 r-xp /usr/lib/libunwind.so.8.0.1
b6c6e000 b6e1c000 r-xp /lib/libc-2.20-2014.11.so
b6e24000 b6f67000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f69000 b6fc1000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc2000 b6ff6000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ff9000 b70cd000 r-xp /usr/lib/libedje.so.1.13.0
b70d0000 b70fc000 r-xp /usr/lib/libecore.so.1.13.0
b710d000 b7333000 r-xp /usr/lib/libevas.so.1.13.0
b735b000 b7373000 r-xp /lib/libpthread-2.20-2014.11.so
b7377000 b76f1000 r-xp /usr/lib/libelementary.so.1.13.0
b7711000 b7715000 r-xp /usr/lib/libsmack.so.1.0.0
b7716000 b771f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7720000 b7723000 r-xp /usr/lib/libdlog.so.0.0.0
b7724000 b7729000 r-xp /usr/lib/libbundle.so.0.1.22
b772a000 b772d000 r-xp /lib/libdl-2.20-2014.11.so
b772f000 b7754000 r-xp /usr/lib/libaul.so.0.1.0
b7757000 b7759000 r-xp /usr/lib/libappsvc.so.0.1.0
b775a000 b775f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7760000 b7767000 r-xp /usr/lib/libappcore-efl.so.1.1
b7769000 b776e000 r-xp /usr/lib/libsys-assert.so
b7771000 b7772000 r-xp [vdso]
b7772000 b7794000 r-xp /lib/ld-2.20-2014.11.so
b7796000 b779e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3341)
Call Stack Count: 9
 0: (0xb6bac1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb37d52e3) [/opt/usr/apps/org.example.example/bin/example] + 0xb2e3
 2: app_pause + 0x29 (0xb37d3d99) [/opt/usr/apps/org.example.example/bin/example] + 0x9d99
 3: (0xb775bce2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb776415a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb775cc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb37d3cc5) [/opt/usr/apps/org.example.example/bin/example] + 0x9cc5
 7: (0xb7798148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7798148
 8: __libc_start_main + 0xde (0xb6c85e4e) [/lib/libc.so.6] + 0x17e4e
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
 appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
06-13 13:19:03.158+0900 D/APP_CORE( 3341): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 13:19:03.158+0900 D/AUL     ( 3341): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 13:19:03.158+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 13:19:03.158+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:19:03.158+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:19:03.158+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 13:19:03.158+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 13:19:03.158+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 13:19:03.158+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 13:19:03.158+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 13:19:03.158+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-13 13:19:03.168+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 13:19:03.168+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:19:03.168+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:19:03.168+0900 D/AUL_AMD ( 2808): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3341 is org.example.example
06-13 13:19:03.168+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3341 : 0
06-13 13:19:03.168+0900 D/AUL     ( 2936): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 13:19:03.368+0900 D/APP_CORE( 3341): appcore.c: __prt_ltime(236) > [APP 3341] first idle after reset: 362 msec
06-13 13:19:03.448+0900 E/E17     ( 2766): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 13:19:03.448+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 13:19:03.448+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 13:19:03.448+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 13:19:03.448+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
06-13 13:19:03.448+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
06-13 13:19:03.448+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:19:03.448+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
06-13 13:19:03.448+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 13:19:03.448+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 13:19:03.448+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:19:03.448+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:19:03.458+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
06-13 13:19:03.458+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 13:19:03.458+0900 D/AUL     ( 2808): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 13:19:03.458+0900 W/AUL     ( 2808): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
06-13 13:19:03.458+0900 D/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2891) > pid(3341) status(3)
06-13 13:19:03.458+0900 D/AUL_AMD ( 2808): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 13:19:03.468+0900 D/DATA_PROVIDER_MASTER( 2928): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
06-13 13:19:03.468+0900 D/DATA_PROVIDER_MASTER( 2928): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 13:19:03.468+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 13:19:03.468+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 13:19:03.468+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: bg
06-13 13:19:03.468+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 13:19:03.468+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3017
06-13 13:19:03.468+0900 D/RESOURCED( 2854): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3017, appname = org.tizen.calendar.widget
06-13 13:19:03.468+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3017
06-13 13:19:03.468+0900 W/AUL_AMD ( 2808): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:19:03.468+0900 W/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 13:19:03.468+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(3341) status(3)
06-13 13:19:03.468+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(3341) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 13:19:03.468+0900 D/AUL     ( 2808): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 13:19:03.468+0900 W/AUL     ( 2808): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3341, appid: org.example.example, status: fg
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 13:19:03.468+0900 I/APP_CORE( 3341): appcore-efl.c: __do_app(496) > [APP 3341] Event: RESUME State: CREATED
06-13 13:19:03.468+0900 D/LAUNCH  ( 3341): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:19:03.468+0900 D/APP_CORE( 3341): appcore-efl.c: __do_app(607) > [APP 3341] RESUME
06-13 13:19:03.468+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3341
06-13 13:19:03.468+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3341, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 13:19:03.468+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3341
06-13 13:19:03.468+0900 I/APP_CORE( 3341): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 13:19:03.478+0900 I/APP_CORE( 3341): appcore-efl.c: __do_app(614) > [APP 3341] Initial Launching, call the resume_cb
06-13 13:19:03.478+0900 I/CAPI_APPFW_APPLICATION( 3341): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 13:19:03.478+0900 D/LAUNCH  ( 3341): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 13:19:03.478+0900 D/LAUNCH  ( 3341): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 13:19:03.478+0900 D/APP_CORE( 3341): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:19:03.478+0900 E/APP_CORE( 3341): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:19:03.508+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3341, appname = org.example.example, pkgname = org.example.example
06-13 13:19:03.508+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3341, appname = org.example.example
06-13 13:19:03.508+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3341
06-13 13:19:03.508+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 13:19:03.508+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 13:19:03.588+0900 D/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2910) > pid(3341) status(0)
06-13 13:19:03.998+0900 E/PKGMGR_SERVER( 3478): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:19:03.998+0900 E/PKGMGR_SERVER( 3478): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 13:19:04.108+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 13:19:04.108+0900 D/AUL_PAD ( 3558): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 13:19:04.118+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 13:19:04.118+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.179
06-13 13:19:04.618+0900 D/AUL_AMD ( 2808): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 13:19:04.618+0900 D/RUA     ( 2808): rua.c: rua_add_history(179) > rua_add_history start
06-13 13:19:04.628+0900 D/RUA     ( 2808): rua.c: rua_add_history(247) > rua_add_history ok
06-13 13:19:05.148+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 13:19:05.148+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 13:19:05.148+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b96eb760
06-13 13:19:05.148+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:19:05.148+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(73) > get shutdown function
06-13 13:19:05.158+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b96eba40
06-13 13:19:05.158+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b96ed640
06-13 13:19:05.158+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:19:05.168+0900 D/AUL_PAD ( 3558): preload.h: __preload_init(73) > get shutdown function
06-13 13:19:05.168+0900 D/AUL_PAD ( 3558): preexec.h: __preexec_init(76) > preexec start
06-13 13:19:05.168+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 13:19:05.168+0900 D/AUL     ( 3558): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 13:19:05.168+0900 D/AUL     ( 3558): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 13:19:05.168+0900 D/AUL     ( 3558): process_pool.c: __connect_to_launchpad(132) > send(3558) : 4
06-13 13:19:05.168+0900 D/AUL     ( 3558): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 13:19:05.168+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3558
06-13 13:19:05.248+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 13:19:05.258+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 13:19:05.258+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 13:19:05.258+0900 D/AUL_PAD ( 3558): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 13:19:08.458+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 13:19:08.458+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
06-13 13:19:08.458+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 13:19:08.458+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
06-13 13:19:08.458+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 13:19:08.458+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
06-13 13:19:10.348+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:19:10.348+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:19:10.348+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:19:10.348+0900 E/INDICATOR( 2856): 
06-13 13:19:30.377+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:19:30.377+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:19:30.377+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:19:30.377+0900 E/INDICATOR( 2856): 
06-13 13:19:44.507+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:19:44.507+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:19:44.507+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:19:44.507+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:19:50.397+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:19:50.397+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:19:50.397+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:19:50.397+0900 E/INDICATOR( 2856): 
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:20 4 h"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:20"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;20"
06-13 13:20:01.007+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147175332 Time: <font_size=33>1&#x2236;20</font_size> <font_size=32>PM</font_size></font>
06-13 13:20:10.417+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:20:10.417+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:20:10.417+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:20:10.417+0900 E/INDICATOR( 2856): 
06-13 13:20:30.427+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:20:30.427+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:20:30.427+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:20:30.427+0900 E/INDICATOR( 2856): 
06-13 13:20:44.526+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:20:44.526+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:20:44.526+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:20:44.526+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:20:50.436+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:20:50.436+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:20:50.436+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:20:50.436+0900 E/INDICATOR( 2856): 
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:21 4 h"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:21"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;21"
06-13 13:21:00.016+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147173280 Time: <font_size=33>1&#x2236;21</font_size> <font_size=32>PM</font_size></font>
06-13 13:21:10.446+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:21:10.446+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:21:10.446+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:21:10.446+0900 E/INDICATOR( 2856): 
06-13 13:21:30.476+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:21:30.476+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:21:30.476+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:21:30.476+0900 E/INDICATOR( 2856): 
06-13 13:21:44.536+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:21:44.536+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:21:44.536+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:21:44.536+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:21:44.536+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > storage cache is empty
06-13 13:21:50.496+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:21:50.496+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:21:50.496+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:21:50.496+0900 E/INDICATOR( 2856): 
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:22 4 h"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:22"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;22"
06-13 13:22:00.025+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147171228 Time: <font_size=33>1&#x2236;22</font_size> <font_size=32>PM</font_size></font>
06-13 13:22:10.505+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:22:10.505+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:22:10.505+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:22:10.505+0900 E/INDICATOR( 2856): 
06-13 13:22:30.525+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:22:30.525+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:22:30.525+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:22:30.525+0900 E/INDICATOR( 2856): 
06-13 13:22:44.525+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:22:44.525+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:22:44.525+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:22:44.525+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:22:50.545+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:22:50.545+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:22:50.545+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:22:50.545+0900 E/INDICATOR( 2856): 
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:23 4 h"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:23"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;23"
06-13 13:23:00.045+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147169176 Time: <font_size=33>1&#x2236;23</font_size> <font_size=32>PM</font_size></font>
06-13 13:23:10.555+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:23:10.555+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:23:10.555+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:23:10.555+0900 E/INDICATOR( 2856): 
06-13 13:23:30.574+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:23:30.574+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:23:30.574+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:23:30.574+0900 E/INDICATOR( 2856): 
06-13 13:23:44.534+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:23:44.534+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:23:44.534+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:23:44.534+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:23:50.594+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:23:50.594+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:23:50.594+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:23:50.594+0900 E/INDICATOR( 2856): 
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:24 4 h"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:24"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;24"
06-13 13:24:00.054+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147167124 Time: <font_size=33>1&#x2236;24</font_size> <font_size=32>PM</font_size></font>
06-13 13:24:10.614+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:24:10.614+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:24:10.614+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:24:10.614+0900 E/INDICATOR( 2856): 
06-13 13:24:30.634+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:24:30.634+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:24:30.634+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:24:30.634+0900 E/INDICATOR( 2856): 
06-13 13:24:44.533+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:24:44.533+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:24:44.533+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:24:44.533+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:24:50.653+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:24:50.653+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:24:50.653+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:24:50.653+0900 E/INDICATOR( 2856): 
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:25 4 h"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:25"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;25"
06-13 13:25:00.063+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147165072 Time: <font_size=33>1&#x2236;25</font_size> <font_size=32>PM</font_size></font>
06-13 13:25:10.673+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:25:10.673+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:25:10.673+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:25:10.673+0900 E/INDICATOR( 2856): 
06-13 13:25:30.693+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:25:30.693+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:25:30.693+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:25:30.693+0900 E/INDICATOR( 2856): 
06-13 13:25:44.543+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:25:44.543+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:25:44.543+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:25:44.543+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:25:44.543+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > battery cache is empty
06-13 13:25:50.713+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:25:50.713+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:25:50.713+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:25:50.713+0900 E/INDICATOR( 2856): 
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:26 4 h"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:26"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;26"
06-13 13:26:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147163020 Time: <font_size=33>1&#x2236;26</font_size> <font_size=32>PM</font_size></font>
06-13 13:26:10.732+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:26:10.732+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:26:10.732+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:26:10.732+0900 E/INDICATOR( 2856): 
06-13 13:26:30.752+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:26:30.752+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:26:30.752+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:26:30.752+0900 E/INDICATOR( 2856): 
06-13 13:26:44.532+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:26:44.532+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:26:44.532+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:26:44.532+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:26:50.772+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:26:50.772+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:26:50.772+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:26:50.772+0900 E/INDICATOR( 2856): 
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:27 4 h"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:27"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;27"
06-13 13:27:00.082+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147160968 Time: <font_size=33>1&#x2236;27</font_size> <font_size=32>PM</font_size></font>
06-13 13:27:10.782+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:27:10.782+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:27:10.782+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:27:10.782+0900 E/INDICATOR( 2856): 
06-13 13:27:30.791+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:27:30.791+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:27:30.791+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:27:30.791+0900 E/INDICATOR( 2856): 
06-13 13:27:44.531+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:27:44.531+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:27:44.531+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:27:44.531+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:27:44.531+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > storage cache is empty
06-13 13:27:50.811+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:27:50.811+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:27:50.811+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:27:50.811+0900 E/INDICATOR( 2856): 
06-13 13:28:00.081+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:28 4 h"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:28"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;28"
06-13 13:28:00.091+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147158916 Time: <font_size=33>1&#x2236;28</font_size> <font_size=32>PM</font_size></font>
06-13 13:28:06.151+0900 E/PKGMGR_SERVER( 3593): pkgmgr-server.c: main(2209) > package manager server start
06-13 13:28:06.151+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 13:28:06.161+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 13:28:06.161+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 13:28:06.171+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 13:28:06.171+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 13:28:06.171+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.182
06-13 13:28:06.181+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 3591
06-13 13:28:06.181+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 3591
06-13 13:28:06.181+0900 D/PKGMGR  ( 3593): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-592452007, 14, tpk, org.example.example, , host)
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3593): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-592452007] [14] [tpk] [org.example.example] [] [] [host]
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3593): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3593): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3593): pkgmgr-server.c: queue_job(1884) > child forked [3596] for request type [14]
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3596): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3596): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3593): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 13:28:06.181+0900 D/PKGMGR  ( 3591): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 13:28:06.181+0900 D/PKGMGR  ( 3591): . 
06-13 13:28:06.181+0900 E/PKGMGR  ( 3591): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 13:28:06.181+0900 D/PKGMGR_SERVER( 3596): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 13:28:06.191+0900 D/AUL     ( 3596): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:28:06.191+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:28:06.191+0900 D/AUL_AMD ( 2808): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:28:06.191+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3341
06-13 13:28:06.191+0900 W/AUL_AMD ( 2808): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3341
06-13 13:28:06.191+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 13:28:06.191+0900 D/AUL     ( 3596): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 13:28:06.191+0900 D/AUL     ( 3596): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 3341
06-13 13:28:06.191+0900 D/AUL     ( 3596): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 13:28:06.191+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 3341, 
06-13 13:28:06.201+0900 D/AUL     ( 2808): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(3341) : cmd(4)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_launch.c: _term_app(1076) > term done
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 13:28:06.201+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3341
06-13 13:28:06.201+0900 D/APP_CORE( 3341): appcore.c: __aul_handler(632) > [APP 3341]     AUL event: AUL_TERMINATE
06-13 13:28:06.201+0900 I/APP_CORE( 3341): appcore-efl.c: __do_app(496) > [APP 3341] Event: TERMINATE State: RUNNING
06-13 13:28:06.201+0900 D/APP_CORE( 3341): appcore-efl.c: __do_app(517) > [APP 3341] TERMINATE
06-13 13:28:06.201+0900 W/AUL_AMD ( 2808): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(3341), cmd(4)
06-13 13:28:06.201+0900 D/AUL     ( 3596): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 13:28:06.201+0900 D/AUL     ( 3596): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3341
06-13 13:28:06.201+0900 W/AUL_AMD ( 2808): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3341
06-13 13:28:06.201+0900 D/AUL     ( 3341): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:28:06.201+0900 W/AUL_AMD ( 2808): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(3341) status(5)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(3341) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:28:06.201+0900 D/AUL     ( 3341): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:28:06.201+0900 W/AUL_AMD ( 2808): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(3341) status(5)
06-13 13:28:06.201+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(3341) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:28:06.211+0900 D/APP_CORE( 3341): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 13:28:06.211+0900 D/APP_CORE( 3341): appcore-efl.c: __after_loop(1169) > [APP 3341] PAUSE before termination
06-13 13:28:06.211+0900 I/CAPI_APPFW_APPLICATION( 3341): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:28:06.211+0900 I/user_tag0( 3341): /opt/usr/apps/org.example.example/data/test.db
06-13 13:28:06.251+0900 W/CRASH_MANAGER( 3598): worker.c: worker_job(1204) > 1103341657861149732808
