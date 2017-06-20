S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 4027
Date: 2017-06-13 13:49:26+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb7f6ca58
ebp = 0xbfff7308, esp = 0xbfff72a0
eax = 0xb7f6ca58, ebx = 0xb6b4e0d4
ecx = 0xb375b000, edx = 0x00000000
eip = 0xb6b2c1f6

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         6 KB
Cached:     166860 KB
VmPeak:     110816 KB
VmSize:     110816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24156 KB
VmRSS:       24156 KB
VmData:      43088 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4027 TID = 4027
4027 4050 4185 4187 

Maps Information
b2aec000 b2af6000 r-xp /usr/lib/libfeedback.so.0.1.4
b2afc000 b2b08000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b09000 b2b2a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b2f000 b2b30000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b31000 b2b36000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b37000 b2b38000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b39000 b2b3b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b3c000 b2b3e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b3f000 b2b4b000 r-xp /usr/lib/libdrm.so.2.4.0
b2b4c000 b2b4f000 r-xp /usr/lib/libdri2.so.0.0.0
b2b50000 b2b5a000 r-xp /usr/lib/libtbm.so.1.0.0
b2b5b000 b2b5c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b5d000 b2b72000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b73000 b2b85000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3387000 b33b8000 r-xp /usr/lib/libidn.so.11.5.44
b33b9000 b33db000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33dc000 b33ec000 r-xp /usr/lib/libcares.so.2.1.0
b33ed000 b33f6000 r-xp /usr/lib/libeventsystem.so.0.0.1
b33f7000 b33fd000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b33fe000 b3414000 r-xp /usr/lib/libalarm.so.0.0.0
b3416000 b341f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3420000 b3497000 r-xp /usr/lib/libcurl.so.4.3.0
b3499000 b34ab000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34ac000 b34af000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b34b0000 b34b3000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b34b4000 b34d5000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34dc000 b34dd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34de000 b34df000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34e0000 b34e3000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34e4000 b34e7000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35ef000 b35f5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f6000 b373a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b374a000 b3759000 r-xp /opt/usr/apps/org.example.example/bin/example
b375c000 b3795000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4198000 b41a3000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a5000 b41b0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41b2000 b41c9000 r-xp /lib/libnsl-2.20-2014.11.so
b41cd000 b41d5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d7000 b41fb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41fc000 b41fd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41fe000 b4201000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4202000 b4209000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b420a000 b4214000 r-xp /usr/lib/libsensord-share.so
b4215000 b4231000 r-xp /usr/lib/libsensor.so.1.2.0
b4233000 b423c000 r-xp /usr/lib/libappcore-common.so.1.1
b423f000 b4241000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4256000 b4258000 r-xp /usr/lib/libXau.so.6.0.0
b4259000 b427b000 r-xp /usr/lib/libxcb.so.1.1.0
b427d000 b4286000 r-xp /lib/libcrypt-2.20-2014.11.so
b42af000 b42b1000 r-xp /usr/lib/libiri.so
b42b2000 b42d8000 r-xp /lib/libexpat.so.1.5.2
b42da000 b4345000 r-xp /usr/lib/libssl.so.1.0.0
b434b000 b4357000 r-xp /usr/lib/libethumb.so.1.13.0
b4358000 b435c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b435d000 b45ae000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b29000 b5b39000 r-xp /usr/lib/libXi.so.6.1.0
b5b3a000 b5b3c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b3d000 b5b43000 r-xp /usr/lib/libXtst.so.6.1.0
b5b44000 b5b4e000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4f000 b5b58000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b5a000 b5b5c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b5d000 b5b62000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b63000 b5b75000 r-xp /usr/lib/libXext.so.6.4.0
b5b76000 b5b78000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b79000 b5b7b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b7d000 b5cbf000 r-xp /usr/lib/libX11.so.6.3.0
b5cc3000 b5ccd000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cce000 b5ce4000 r-xp /usr/lib/libudev.so.1.6.0
b5ce7000 b5ceb000 r-xp /lib/libattr.so.1.1.0
b5cec000 b5d1b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d1d000 b5d23000 r-xp /usr/lib/libffi.so.6.0.2
b5d24000 b5d47000 r-xp /lib/libz.so.1.2.8
b5d48000 b5d4b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d4c000 b5ea8000 r-xp /usr/lib/libxml2.so.2.9.2
b5eae000 b5f95000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fa2000 b5fa5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa6000 b5fc8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc9000 b5fdd000 r-xp /lib/libresolv-2.20-2014.11.so
b5fe1000 b6005000 r-xp /usr/lib/liblzma.so.5.0.3
b6006000 b6008000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b600a000 b6014000 r-xp /usr/lib/libembryo.so.1.13.0
b6015000 b603e000 r-xp /usr/lib/libpng12.so.0.50.0
b603f000 b6088000 r-xp /usr/lib/libjpeg.so.8.0.2
b6099000 b60a0000 r-xp /lib/librt-2.20-2014.11.so
b60a2000 b60c1000 r-xp /usr/lib/libector.so.1.13.0
b60c4000 b60f1000 r-xp /usr/lib/liblua-5.1.so
b60f2000 b6182000 r-xp /usr/lib/libfreetype.so.6.11.3
b6186000 b61c4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c5000 b61db000 r-xp /usr/lib/libfribidi.so.0.3.1
b61dc000 b6235000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6238000 b6283000 r-xp /lib/libm-2.20-2014.11.so
b6285000 b6297000 r-xp /usr/lib/libeio.so.1.13.0
b6298000 b629b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b629c000 b62a2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62a3000 b62c6000 r-xp /usr/lib/libefreet.so.1.13.0
b62c9000 b62f4000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f5000 b6329000 r-xp /usr/lib/libecore_con.so.1.13.0
b632b000 b6334000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6335000 b633e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633f000 b6352000 r-xp /usr/lib/libeo.so.1.13.0
b6354000 b6367000 r-xp /usr/lib/libecore_input.so.1.13.0
b6368000 b636f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6370000 b6393000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6394000 b63c0000 r-xp /usr/lib/libeet.so.1.13.0
b63c9000 b6434000 r-xp /usr/lib/libeina.so.1.13.0
b6437000 b644e000 r-xp /usr/lib/libefl.so.1.13.0
b6450000 b65b7000 r-xp /usr/lib/libicuuc.so.51.1
b65c5000 b67d1000 r-xp /usr/lib/libicui18n.so.51.1
b67d9000 b6828000 r-xp /usr/lib/libecore_x.so.1.13.0
b682a000 b6844000 r-xp /lib/libgcc_s-4.9.so.1
b6846000 b684a000 r-xp /lib/libcap.so.2.21
b684b000 b6891000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6892000 b6899000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b689b000 b68ed000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ef000 b6a7a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7f000 b6b4d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b50000 b6b54000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b55000 b6b64000 r-xp /usr/lib/libvconf.so.0.2.45
b6b65000 b6b68000 r-xp /usr/lib/libvasum.so.0.3.1
b6b69000 b6b6c000 r-xp /usr/lib/libttrace.so.1.1
b6b6e000 b6b72000 r-xp /usr/lib/libiniparser.so.0
b6b73000 b6ba3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ba4000 b6bad000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bae000 b6bd3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bd4000 b6be4000 r-xp /usr/lib/libunwind.so.8.0.1
b6bee000 b6d9c000 r-xp /lib/libc-2.20-2014.11.so
b6da4000 b6ee7000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee9000 b6f41000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f42000 b6f76000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f79000 b704d000 r-xp /usr/lib/libedje.so.1.13.0
b7050000 b707c000 r-xp /usr/lib/libecore.so.1.13.0
b708d000 b72b3000 r-xp /usr/lib/libevas.so.1.13.0
b72db000 b72f3000 r-xp /lib/libpthread-2.20-2014.11.so
b72f7000 b7671000 r-xp /usr/lib/libelementary.so.1.13.0
b7691000 b7695000 r-xp /usr/lib/libsmack.so.1.0.0
b7696000 b769f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a0000 b76a3000 r-xp /usr/lib/libdlog.so.0.0.0
b76a4000 b76a9000 r-xp /usr/lib/libbundle.so.0.1.22
b76aa000 b76ad000 r-xp /lib/libdl-2.20-2014.11.so
b76af000 b76d4000 r-xp /usr/lib/libaul.so.0.1.0
b76d7000 b76d9000 r-xp /usr/lib/libappsvc.so.0.1.0
b76da000 b76df000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76e0000 b76e7000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e9000 b76ee000 r-xp /usr/lib/libsys-assert.so
b76f1000 b76f2000 r-xp [vdso]
b76f2000 b7714000 r-xp /lib/ld-2.20-2014.11.so
b7716000 b771e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4027)
Call Stack Count: 9
 0: (0xb6b2c1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb3755393) [/opt/usr/apps/org.example.example/bin/example] + 0xb393
 2: app_pause + 0x29 (0xb3753e49) [/opt/usr/apps/org.example.example/bin/example] + 0x9e49
 3: (0xb76dbce2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb76e415a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb76dcc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb3753d75) [/opt/usr/apps/org.example.example/bin/example] + 0x9d75
 7: (0xb7718148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7718148
 8: __libc_start_main + 0xde (0xb6c05e4e) [/lib/libc.so.6] + 0x17e4e
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
=======> Broadcast mDNIeStatus : PID=4027
06-13 13:41:34.411+0900 D/LAUNCH  ( 4027): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 13:41:34.411+0900 I/run     ( 4027): socket
06-13 13:41:34.411+0900 I/tag     ( 4027): eonji~
06-13 13:41:34.411+0900 D/APP_CORE( 4027): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 13:41:34.411+0900 I/run     ( 4027): connect
06-13 13:41:34.411+0900 I/run     ( 4027): new
06-13 13:41:34.411+0900 I/run     ( 4027): send
06-13 13:41:34.411+0900 E/EFL     ( 4027): edje<4027> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:41:34.411+0900 E/EFL     ( 4027): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:41:34.411+0900 E/EFL     ( 4027): edje<4027> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:41:34.411+0900 E/EFL     ( 4027): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:41:34.411+0900 E/EFL     ( 4027): edje<4027> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:41:34.411+0900 E/EFL     ( 4027): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:41:34.411+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:41:34.411+0900 E/EFL     ( 4027): edje<4027> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:41:34.411+0900 E/EFL     ( 4027): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:41:34.411+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:41:34.411+0900 E/EFL     ( 4027): edje<4027> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 13:41:34.411+0900 E/EFL     ( 4027): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:41:34.421+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 13:41:34.421+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 13:41:34.421+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 13:41:34.421+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 13:41:34.421+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 13:41:34.421+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-13 13:41:34.421+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 13:41:34.421+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:41:34.421+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 13:41:34.421+0900 W/APP_CORE( 4027): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
06-13 13:41:34.421+0900 D/APP_CORE( 4027): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
06-13 13:41:34.421+0900 D/APP_CORE( 4027): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 13:41:34.421+0900 D/AUL     ( 4027): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 13:41:34.421+0900 D/AUL_AMD ( 2808): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4027 is org.example.example
06-13 13:41:34.421+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4027 : 0
06-13 13:41:34.421+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 13:41:34.421+0900 D/AUL     ( 2936): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 13:41:34.961+0900 D/APP_CORE( 4027): appcore.c: __prt_ltime(236) > [APP 4027] first idle after reset: 711 msec
06-13 13:41:35.011+0900 E/E17     ( 2766): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 13:41:35.011+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 13:41:35.011+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 13:41:35.011+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 13:41:35.011+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
06-13 13:41:35.011+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
06-13 13:41:35.011+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:41:35.011+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
06-13 13:41:35.011+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 13:41:35.011+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 13:41:35.011+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:41:35.011+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 13:41:35.011+0900 D/AUL     ( 2808): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 13:41:35.011+0900 W/AUL     ( 2808): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2891) > pid(4027) status(3)
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 13:41:35.011+0900 W/AUL_AMD ( 2808): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:41:35.011+0900 W/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(4027) status(3)
06-13 13:41:35.011+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(4027) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 13:41:35.011+0900 D/AUL     ( 2808): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 13:41:35.011+0900 W/AUL     ( 2808): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 4027, appid: org.example.example, status: fg
06-13 13:41:35.011+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4027
06-13 13:41:35.011+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4027, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 13:41:35.011+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4027
06-13 13:41:35.011+0900 D/DATA_PROVIDER_MASTER( 2928): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
06-13 13:41:35.011+0900 D/DATA_PROVIDER_MASTER( 2928): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 13:41:35.011+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 13:41:35.011+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 13:41:35.011+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: bg
06-13 13:41:35.091+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4027, appname = org.example.example, pkgname = org.example.example
06-13 13:41:35.091+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4027, appname = org.example.example
06-13 13:41:35.091+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4027
06-13 13:41:35.091+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 13:41:35.091+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3017
06-13 13:41:35.091+0900 D/RESOURCED( 2854): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3017, appname = org.tizen.calendar.widget
06-13 13:41:35.091+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3017
06-13 13:41:35.091+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 13:41:35.091+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 13:41:35.091+0900 I/APP_CORE( 4027): appcore-efl.c: __do_app(496) > [APP 4027] Event: RESUME State: CREATED
06-13 13:41:35.091+0900 D/LAUNCH  ( 4027): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __do_app(607) > [APP 4027] RESUME
06-13 13:41:35.091+0900 I/APP_CORE( 4027): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 13:41:35.091+0900 I/APP_CORE( 4027): appcore-efl.c: __do_app(614) > [APP 4027] Initial Launching, call the resume_cb
06-13 13:41:35.091+0900 I/CAPI_APPFW_APPLICATION( 4027): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 13:41:35.091+0900 D/LAUNCH  ( 4027): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 13:41:35.091+0900 D/LAUNCH  ( 4027): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 13:41:35.091+0900 D/APP_CORE( 4027): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:41:35.091+0900 E/APP_CORE( 4027): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:41:35.131+0900 D/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2910) > pid(4027) status(0)
06-13 13:41:35.371+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 13:41:35.371+0900 D/AUL_PAD ( 4188): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 13:41:35.371+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 13:41:35.371+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.234
06-13 13:41:35.871+0900 D/AUL_AMD ( 2808): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 13:41:35.871+0900 D/RUA     ( 2808): rua.c: rua_add_history(179) > rua_add_history start
06-13 13:41:35.871+0900 D/RUA     ( 2808): rua.c: rua_add_history(247) > rua_add_history ok
06-13 13:41:36.001+0900 E/PKGMGR_SERVER( 4128): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:41:36.001+0900 E/PKGMGR_SERVER( 4128): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 13:41:36.401+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 13:41:36.401+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 13:41:36.401+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b84f8760
06-13 13:41:36.401+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:41:36.401+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(73) > get shutdown function
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b84f8a40
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b84fa640
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(69) > get pre-initialization function
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): preload.h: __preload_init(73) > get shutdown function
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): preexec.h: __preexec_init(76) > preexec start
06-13 13:41:36.421+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 13:41:36.421+0900 D/AUL     ( 4188): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 13:41:36.421+0900 D/AUL     ( 4188): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 13:41:36.421+0900 D/AUL     ( 4188): process_pool.c: __connect_to_launchpad(132) > send(4188) : 4
06-13 13:41:36.421+0900 D/AUL     ( 4188): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 13:41:36.421+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4188
06-13 13:41:36.431+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.235
06-13 13:41:36.551+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 13:41:36.561+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 13:41:36.561+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 13:41:36.561+0900 D/AUL_PAD ( 4188): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 13:41:40.021+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 13:41:40.021+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
06-13 13:41:40.021+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 13:41:40.021+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
06-13 13:41:40.021+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 13:41:40.021+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
06-13 13:41:44.481+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:41:44.481+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:41:44.481+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:41:44.481+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:41:51.411+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:41:51.411+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:41:51.411+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:41:51.411+0900 E/INDICATOR( 2856): 
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:42 4 h"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:42"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;42"
06-13 13:42:00.660+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147097869 Time: <font_size=33>1&#x2236;42</font_size> <font_size=32>PM</font_size></font>
06-13 13:42:11.420+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:42:11.420+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:42:11.420+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:42:11.420+0900 E/INDICATOR( 2856): 
06-13 13:42:31.440+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:42:31.440+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:42:31.440+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:42:31.440+0900 E/INDICATOR( 2856): 
06-13 13:42:37.780+0900 I/service ( 4027): socket
06-13 13:42:37.780+0900 I/example ( 4027): m
06-13 13:42:37.870+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600471 
06-13 13:42:38.880+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
06-13 13:42:43.880+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600471 bd->visible=1
06-13 13:42:44.540+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:42:44.540+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:42:44.540+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:42:44.540+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:42:51.460+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:42:51.460+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:42:51.460+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:42:51.460+0900 E/INDICATOR( 2856): 
06-13 13:43:00.670+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:43 4 h"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:43"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;43"
06-13 13:43:00.680+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147095817 Time: <font_size=33>1&#x2236;43</font_size> <font_size=32>PM</font_size></font>
06-13 13:43:11.480+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:43:11.480+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:43:11.480+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:43:11.480+0900 E/INDICATOR( 2856): 
06-13 13:43:31.489+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:43:31.489+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:43:31.489+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:43:31.489+0900 E/INDICATOR( 2856): 
06-13 13:43:44.539+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:43:44.539+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:43:44.539+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:43:44.549+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:43:51.499+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:43:51.499+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:43:51.499+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:43:51.499+0900 E/INDICATOR( 2856): 
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:44 4 h"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:44"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;44"
06-13 13:44:00.689+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147093765 Time: <font_size=33>1&#x2236;44</font_size> <font_size=32>PM</font_size></font>
06-13 13:44:11.509+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:44:11.509+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:44:11.509+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:44:11.509+0900 E/INDICATOR( 2856): 
06-13 13:44:31.538+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:44:31.538+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:44:31.538+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:44:31.538+0900 E/INDICATOR( 2856): 
06-13 13:44:44.538+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:44:44.538+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:44:44.538+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:44:44.538+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:44:51.558+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:44:51.558+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:44:51.558+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:44:51.558+0900 E/INDICATOR( 2856): 
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:45 4 h"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:45"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;45"
06-13 13:45:00.698+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147091713 Time: <font_size=33>1&#x2236;45</font_size> <font_size=32>PM</font_size></font>
06-13 13:45:11.558+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:45:11.558+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:45:11.558+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:45:11.558+0900 E/INDICATOR( 2856): 
06-13 13:45:31.578+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:45:31.578+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:45:31.578+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:45:31.578+0900 E/INDICATOR( 2856): 
06-13 13:45:44.548+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:45:44.548+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:45:44.548+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:45:44.548+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:45:44.548+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > storage cache is empty
06-13 13:45:51.597+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:45:51.597+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:45:51.597+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:45:51.597+0900 E/INDICATOR( 2856): 
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:46 4 h"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:46"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;46"
06-13 13:46:00.697+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147089661 Time: <font_size=33>1&#x2236;46</font_size> <font_size=32>PM</font_size></font>
06-13 13:46:11.607+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:46:11.607+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:46:11.607+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:46:11.607+0900 E/INDICATOR( 2856): 
06-13 13:46:29.517+0900 I/service ( 4027): socket
06-13 13:46:29.517+0900 I/example ( 4027): m
06-13 13:46:29.607+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x600471 
06-13 13:46:30.607+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
06-13 13:46:31.627+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:46:31.627+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:46:31.627+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:46:31.627+0900 E/INDICATOR( 2856): 
06-13 13:46:35.607+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x600471 bd->visible=1
06-13 13:46:44.537+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:46:44.537+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:46:44.537+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:46:44.547+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:46:51.657+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:46:51.657+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:46:51.657+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:46:51.657+0900 E/INDICATOR( 2856): 
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:47 4 h"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:47"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;47"
06-13 13:47:00.707+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147087609 Time: <font_size=33>1&#x2236;47</font_size> <font_size=32>PM</font_size></font>
06-13 13:47:11.666+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:47:11.666+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:47:11.666+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:47:11.666+0900 E/INDICATOR( 2856): 
06-13 13:47:31.686+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:47:31.686+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:47:31.686+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:47:31.686+0900 E/INDICATOR( 2856): 
06-13 13:47:44.546+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:47:44.546+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:47:44.546+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:47:44.546+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:47:44.556+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > battery cache is empty
06-13 13:47:51.706+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:47:51.706+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:47:51.706+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:47:51.706+0900 E/INDICATOR( 2856): 
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:48 4 h"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:48"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;48"
06-13 13:48:00.716+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147085557 Time: <font_size=33>1&#x2236;48</font_size> <font_size=32>PM</font_size></font>
06-13 13:48:11.716+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:48:11.716+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:48:11.716+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:48:11.716+0900 E/INDICATOR( 2856): 
06-13 13:48:31.735+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:48:31.735+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:48:31.735+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:48:31.735+0900 E/INDICATOR( 2856): 
06-13 13:48:44.545+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:48:44.545+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:48:44.545+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:48:44.545+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:48:51.765+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:48:51.765+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:48:51.765+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:48:51.765+0900 E/INDICATOR( 2856): 
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:49 4 h"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:49"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;49"
06-13 13:49:00.735+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147083505 Time: <font_size=33>1&#x2236;49</font_size> <font_size=32>PM</font_size></font>
06-13 13:49:11.775+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:49:11.775+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:49:11.775+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:49:11.775+0900 E/INDICATOR( 2856): 
06-13 13:49:26.535+0900 E/PKGMGR_SERVER( 4226): pkgmgr-server.c: main(2209) > package manager server start
06-13 13:49:26.535+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 13:49:26.545+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 13:49:26.555+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 13:49:26.555+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 13:49:26.565+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 13:49:26.565+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.237
06-13 13:49:26.565+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 4224
06-13 13:49:26.565+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 4224
06-13 13:49:26.565+0900 D/PKGMGR  ( 4226): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_687922955, 14, tpk, org.example.example, , host)
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4226): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_687922955] [14] [tpk] [org.example.example] [] [] [host]
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4226): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4226): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4226): pkgmgr-server.c: queue_job(1884) > child forked [4229] for request type [14]
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4229): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4229): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 13:49:26.565+0900 D/PKGMGR_SERVER( 4226): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 13:49:26.565+0900 D/PKGMGR  ( 4224): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 13:49:26.565+0900 D/PKGMGR  ( 4224): . 
06-13 13:49:26.565+0900 E/PKGMGR  ( 4224): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 13:49:26.575+0900 D/PKGMGR_SERVER( 4229): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 13:49:26.575+0900 D/AUL     ( 4229): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:49:26.575+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:49:26.575+0900 D/AUL_AMD ( 2808): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:49:26.575+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 4027
06-13 13:49:26.575+0900 W/AUL_AMD ( 2808): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 4027
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 13:49:26.585+0900 D/AUL     ( 4229): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 13:49:26.585+0900 D/AUL     ( 4229): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 4027
06-13 13:49:26.585+0900 D/AUL     ( 4229): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : norestart : norestart
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 4027, 
06-13 13:49:26.585+0900 D/AUL     ( 2808): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(4027) : cmd(4)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_launch.c: _term_app(1076) > term done
06-13 13:49:26.585+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4027
06-13 13:49:26.585+0900 D/APP_CORE( 4027): appcore.c: __aul_handler(632) > [APP 4027]     AUL event: AUL_TERMINATE
06-13 13:49:26.585+0900 I/APP_CORE( 4027): appcore-efl.c: __do_app(496) > [APP 4027] Event: TERMINATE State: RUNNING
06-13 13:49:26.585+0900 D/APP_CORE( 4027): appcore-efl.c: __do_app(517) > [APP 4027] TERMINATE
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 13:49:26.585+0900 W/AUL_AMD ( 2808): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(4027), cmd(4)
06-13 13:49:26.585+0900 D/AUL     ( 4229): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 13:49:26.585+0900 D/AUL     ( 4229): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 4027
06-13 13:49:26.585+0900 W/AUL_AMD ( 2808): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 4027
06-13 13:49:26.585+0900 D/AUL     ( 4027): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:49:26.585+0900 W/AUL_AMD ( 2808): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(4027) status(5)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(4027) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:49:26.585+0900 D/AUL     ( 4027): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:49:26.585+0900 W/AUL_AMD ( 2808): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(4027) status(5)
06-13 13:49:26.585+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(4027) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 13:49:26.595+0900 D/APP_CORE( 4027): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 13:49:26.595+0900 D/APP_CORE( 4027): appcore-efl.c: __after_loop(1169) > [APP 4027] PAUSE before termination
06-13 13:49:26.595+0900 I/CAPI_APPFW_APPLICATION( 4027): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:49:26.595+0900 I/user_tag0( 4027): /opt/usr/apps/org.example.example/data/test.db
06-13 13:49:26.635+0900 W/CRASH_MANAGER( 4231): worker.c: worker_job(1204) > 1104027657861149732936
