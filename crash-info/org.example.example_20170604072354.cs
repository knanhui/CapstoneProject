S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 5657
Date: 2017-06-04 07:23:54+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x17

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000017, esi = 0xbff12190
ebp = 0xbff121a8, esp = 0xbff11c80
eax = 0x00000000, ebx = 0xb6dbf000
ecx = 0xffffffff, edx = 0x00000017
eip = 0xb6c5262b

Memory Information
MemTotal:      123 KB
MemFree:        25 KB
Buffers:         6 KB
Cached:     184320 KB
VmPeak:     122144 KB
VmSize:     118316 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35068 KB
VmRSS:       31188 KB
VmData:      48400 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5657 TID = 5657
5657 5659 5825 5826 5831 

Maps Information
b0e79000 b0e80000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1805000 b181d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b181e000 b1825000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b185c000 b1860000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b35000 b2b3f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b45000 b2b51000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b52000 b2b73000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b78000 b2b79000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b7a000 b2b7f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b80000 b2b81000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b82000 b2b84000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b85000 b2b87000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b88000 b2b94000 r-xp /usr/lib/libdrm.so.2.4.0
b2b95000 b2b98000 r-xp /usr/lib/libdri2.so.0.0.0
b2b99000 b2ba3000 r-xp /usr/lib/libtbm.so.1.0.0
b2ba4000 b2bb9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bba000 b2bcc000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33ce000 b33ff000 r-xp /usr/lib/libidn.so.11.5.44
b3400000 b3422000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3423000 b3433000 r-xp /usr/lib/libcares.so.2.1.0
b3434000 b343d000 r-xp /usr/lib/libeventsystem.so.0.0.1
b343e000 b3447000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3448000 b34bf000 r-xp /usr/lib/libcurl.so.4.3.0
b34c1000 b34d3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34d4000 b34f5000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34fc000 b34fd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34fe000 b34ff000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3500000 b3503000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3504000 b3507000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b360f000 b3615000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3616000 b375a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b376a000 b376b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b376c000 b3779000 r-xp /opt/usr/apps/org.example.example/bin/example
b377c000 b37b5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41b8000 b41c3000 r-xp /lib/libnss_files-2.20-2014.11.so
b41c5000 b41d0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41d2000 b41e9000 r-xp /lib/libnsl-2.20-2014.11.so
b41ed000 b41f5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41f7000 b421b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b421c000 b421d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b421e000 b4221000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4222000 b4229000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b422a000 b4234000 r-xp /usr/lib/libsensord-share.so
b4235000 b4251000 r-xp /usr/lib/libsensor.so.1.2.0
b4253000 b425c000 r-xp /usr/lib/libappcore-common.so.1.1
b425f000 b4261000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4276000 b4278000 r-xp /usr/lib/libXau.so.6.0.0
b4279000 b429b000 r-xp /usr/lib/libxcb.so.1.1.0
b429d000 b42a6000 r-xp /lib/libcrypt-2.20-2014.11.so
b42cf000 b42d1000 r-xp /usr/lib/libiri.so
b42d2000 b42f8000 r-xp /lib/libexpat.so.1.5.2
b42fa000 b4365000 r-xp /usr/lib/libssl.so.1.0.0
b436b000 b4377000 r-xp /usr/lib/libethumb.so.1.13.0
b4378000 b437c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b437d000 b45ce000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b49000 b5b59000 r-xp /usr/lib/libXi.so.6.1.0
b5b5a000 b5b5c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b5d000 b5b63000 r-xp /usr/lib/libXtst.so.6.1.0
b5b64000 b5b6e000 r-xp /usr/lib/libXrender.so.1.3.0
b5b6f000 b5b78000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b7a000 b5b7c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b7d000 b5b82000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b83000 b5b95000 r-xp /usr/lib/libXext.so.6.4.0
b5b96000 b5b98000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b99000 b5b9b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b9d000 b5cdf000 r-xp /usr/lib/libX11.so.6.3.0
b5ce3000 b5ced000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cee000 b5d04000 r-xp /usr/lib/libudev.so.1.6.0
b5d07000 b5d0b000 r-xp /lib/libattr.so.1.1.0
b5d0c000 b5d3b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d3d000 b5d43000 r-xp /usr/lib/libffi.so.6.0.2
b5d44000 b5d67000 r-xp /lib/libz.so.1.2.8
b5d68000 b5d6b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d6c000 b5ec8000 r-xp /usr/lib/libxml2.so.2.9.2
b5ece000 b5fb5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fc2000 b5fc5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fc6000 b5fe8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fe9000 b5ffd000 r-xp /lib/libresolv-2.20-2014.11.so
b6001000 b6025000 r-xp /usr/lib/liblzma.so.5.0.3
b6026000 b6028000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b602a000 b6034000 r-xp /usr/lib/libembryo.so.1.13.0
b6035000 b605e000 r-xp /usr/lib/libpng12.so.0.50.0
b605f000 b60a8000 r-xp /usr/lib/libjpeg.so.8.0.2
b60b9000 b60c0000 r-xp /lib/librt-2.20-2014.11.so
b60c2000 b60e1000 r-xp /usr/lib/libector.so.1.13.0
b60e4000 b6111000 r-xp /usr/lib/liblua-5.1.so
b6112000 b61a2000 r-xp /usr/lib/libfreetype.so.6.11.3
b61a6000 b61e4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61e5000 b61fb000 r-xp /usr/lib/libfribidi.so.0.3.1
b61fc000 b6255000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6258000 b62a3000 r-xp /lib/libm-2.20-2014.11.so
b62a5000 b62b7000 r-xp /usr/lib/libeio.so.1.13.0
b62b8000 b62bb000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62bc000 b62c2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62c3000 b62e6000 r-xp /usr/lib/libefreet.so.1.13.0
b62e9000 b6314000 r-xp /usr/lib/libeldbus.so.1.13.0
b6315000 b6349000 r-xp /usr/lib/libecore_con.so.1.13.0
b634b000 b6354000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6355000 b635e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b635f000 b6372000 r-xp /usr/lib/libeo.so.1.13.0
b6374000 b6387000 r-xp /usr/lib/libecore_input.so.1.13.0
b6388000 b638f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6390000 b63b3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63b4000 b63e0000 r-xp /usr/lib/libeet.so.1.13.0
b63e9000 b6454000 r-xp /usr/lib/libeina.so.1.13.0
b6457000 b646e000 r-xp /usr/lib/libefl.so.1.13.0
b6470000 b65d7000 r-xp /usr/lib/libicuuc.so.51.1
b65e5000 b67f1000 r-xp /usr/lib/libicui18n.so.51.1
b67f9000 b6848000 r-xp /usr/lib/libecore_x.so.1.13.0
b684a000 b6864000 r-xp /lib/libgcc_s-4.9.so.1
b6866000 b686a000 r-xp /lib/libcap.so.2.21
b686b000 b68b1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68b2000 b68b9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68bb000 b690d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b690f000 b6a9a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a9f000 b6b6d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b70000 b6b74000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b75000 b6b84000 r-xp /usr/lib/libvconf.so.0.2.45
b6b85000 b6b88000 r-xp /usr/lib/libvasum.so.0.3.1
b6b89000 b6b8c000 r-xp /usr/lib/libttrace.so.1.1
b6b8e000 b6b92000 r-xp /usr/lib/libiniparser.so.0
b6b93000 b6bc3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bc4000 b6bcd000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bce000 b6bf3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bf4000 b6c04000 r-xp /usr/lib/libunwind.so.8.0.1
b6c0e000 b6dbc000 r-xp /lib/libc-2.20-2014.11.so
b6dc4000 b6f07000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f09000 b6f61000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f62000 b6f96000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f99000 b706d000 r-xp /usr/lib/libedje.so.1.13.0
b7070000 b709c000 r-xp /usr/lib/libecore.so.1.13.0
b70ad000 b72d3000 r-xp /usr/lib/libevas.so.1.13.0
b72fb000 b7313000 r-xp /lib/libpthread-2.20-2014.11.so
b7317000 b7691000 r-xp /usr/lib/libelementary.so.1.13.0
b76b1000 b76b5000 r-xp /usr/lib/libsmack.so.1.0.0
b76b6000 b76bf000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c0000 b76c3000 r-xp /usr/lib/libdlog.so.0.0.0
b76c4000 b76c9000 r-xp /usr/lib/libbundle.so.0.1.22
b76ca000 b76cd000 r-xp /lib/libdl-2.20-2014.11.so
b76cf000 b76f4000 r-xp /usr/lib/libaul.so.0.1.0
b76f7000 b76f9000 r-xp /usr/lib/libappsvc.so.0.1.0
b76fa000 b76ff000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7700000 b7707000 r-xp /usr/lib/libappcore-efl.so.1.1
b7709000 b770e000 r-xp /usr/lib/libsys-assert.so
b7711000 b7712000 r-xp [vdso]
b7712000 b7734000 r-xp /lib/ld-2.20-2014.11.so
b7736000 b773e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5657)
Call Stack Count: 3
 0: _IO_vfprintf + 0x4b1b (0xb6c5262b) [/lib/libc.so.6] + 0x4462b
 1: __vsnprintf_chk + 0xac (0xb6d037ac) [/lib/libc.so.6] + 0xf57ac
 2: ((nil)) (null)
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
E( 5657): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 07:23:23.758+0900 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 07:23:23.758+0900 D/AUL     ( 5657): service.c: __set_bundle(186) > __set_bundle
06-04 07:23:23.758+0900 D/LAUNCH  ( 5657): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 07:23:23.758+0900 D/APP_CORE( 5657): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 07:23:23.758+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:23:23.758+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:23.758+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:23:23.758+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:23.758+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:23:23.758+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:23.758+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:23:23.758+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:23.758+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:23:23.758+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:23.768+0900 W/APP_CORE( 5657): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-04 07:23:23.768+0900 D/APP_CORE( 5657): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-04 07:23:23.768+0900 D/APP_CORE( 5657): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 07:23:23.768+0900 D/AUL     ( 5657): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 07:23:23.768+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5657
06-04 07:23:23.768+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 07:23:23.768+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 07:23:23.768+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 07:23:23.768+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 07:23:23.768+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 07:23:23.768+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 07:23:23.768+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 07:23:23.768+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 07:23:23.808+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 07:23:23.808+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5657, appid: org.example.example
06-04 07:23:23.808+0900 D/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 07:23:23.808+0900 E/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 07:23:23.808+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2700) > add app group info
06-04 07:23:23.808+0900 E/AUL     ( 2753): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 07:23:23.808+0900 D/AUL_AMD ( 2753): amd_status.c: _status_add_app_info_list(427) > pid(5657) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 07:23:23.808+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 07:23:23.808+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 07:23:23.808+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 07:23:23.808+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 07:23:23.808+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 5657
06-04 07:23:23.808+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 07:23:23.808+0900 E/RESOURCED( 2854): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 07:23:23.808+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(888) > available memory = 316
06-04 07:23:23.818+0900 D/AUL_AMD ( 2753): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5657 is org.example.example
06-04 07:23:23.818+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5657 : 0
06-04 07:23:23.818+0900 D/AUL     ( 2937): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 07:23:24.008+0900 D/APP_CORE( 5657): appcore.c: __prt_ltime(236) > [APP 5657] first idle after reset: 306 msec
06-04 07:23:24.038+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 07:23:24.038+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 07:23:24.038+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 07:23:24.038+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 07:23:24.038+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
06-04 07:23:24.038+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
06-04 07:23:24.038+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 07:23:24.038+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
06-04 07:23:24.038+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 07:23:24.038+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 07:23:24.038+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 07:23:24.038+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 07:23:24.038+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 07:23:24.038+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(5657) status(3)
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 07:23:24.038+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 07:23:24.038+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(5657) status(3)
06-04 07:23:24.038+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(5657) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 07:23:24.038+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 07:23:24.038+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5657, appid: org.example.example, status: fg
06-04 07:23:24.038+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5657
06-04 07:23:24.038+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5657, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 07:23:24.038+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5657
06-04 07:23:24.048+0900 D/DATA_PROVIDER_MASTER( 2924): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
06-04 07:23:24.048+0900 D/DATA_PROVIDER_MASTER( 2924): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 07:23:24.048+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 07:23:24.048+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 07:23:24.048+0900 W/AUL     ( 3018): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3018, appid: org.tizen.calendar.widget, status: bg
06-04 07:23:24.098+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5657, appname = org.example.example, pkgname = org.example.example
06-04 07:23:24.098+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5657, appname = org.example.example
06-04 07:23:24.098+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5657
06-04 07:23:24.098+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3018, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 07:23:24.098+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3018
06-04 07:23:24.098+0900 D/RESOURCED( 2854): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3018, appname = org.tizen.calendar.widget
06-04 07:23:24.098+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3018
06-04 07:23:24.098+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 07:23:24.098+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 07:23:24.098+0900 D/APP_CORE( 5657): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 07:23:24.108+0900 I/APP_CORE( 5657): appcore-efl.c: __do_app(496) > [APP 5657] Event: RESUME State: CREATED
06-04 07:23:24.108+0900 D/LAUNCH  ( 5657): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __do_app(607) > [APP 5657] RESUME
06-04 07:23:24.108+0900 I/APP_CORE( 5657): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 07:23:24.108+0900 I/APP_CORE( 5657): appcore-efl.c: __do_app(614) > [APP 5657] Initial Launching, call the resume_cb
06-04 07:23:24.108+0900 I/CAPI_APPFW_APPLICATION( 5657): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 07:23:24.108+0900 D/LAUNCH  ( 5657): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 07:23:24.108+0900 D/LAUNCH  ( 5657): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 07:23:24.108+0900 D/APP_CORE( 5657): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 07:23:24.108+0900 E/APP_CORE( 5657): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 07:23:24.258+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2910) > pid(5657) status(0)
06-04 07:23:24.678+0900 D/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(442) > pid(5491)
06-04 07:23:24.678+0900 W/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 07:23:24.678+0900 D/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(442) > pid(5491)
06-04 07:23:24.678+0900 W/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 07:23:24.818+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 07:23:24.818+0900 D/AUL_PAD ( 5828): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 07:23:24.818+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 07:23:24.998+0900 E/PKGMGR_SERVER( 5751): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 07:23:24.998+0900 E/PKGMGR_SERVER( 5751): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 07:23:25.318+0900 D/AUL_AMD ( 2753): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 07:23:25.318+0900 D/RUA     ( 2753): rua.c: rua_add_history(179) > rua_add_history start
06-04 07:23:25.318+0900 D/RUA     ( 2753): rua.c: rua_add_history(247) > rua_add_history ok
06-04 07:23:25.838+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 07:23:25.838+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 07:23:25.858+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8d5b760
06-04 07:23:25.858+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(69) > get pre-initialization function
06-04 07:23:25.858+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(73) > get shutdown function
06-04 07:23:25.858+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8d5ba40
06-04 07:23:25.868+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8d5d640
06-04 07:23:25.868+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(69) > get pre-initialization function
06-04 07:23:25.868+0900 D/AUL_PAD ( 5828): preload.h: __preload_init(73) > get shutdown function
06-04 07:23:25.868+0900 D/AUL_PAD ( 5828): preexec.h: __preexec_init(76) > preexec start
06-04 07:23:25.868+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 07:23:25.868+0900 D/AUL     ( 5828): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 07:23:25.868+0900 D/AUL     ( 5828): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 07:23:25.868+0900 D/AUL     ( 5828): process_pool.c: __connect_to_launchpad(132) > send(5828) : 4
06-04 07:23:25.868+0900 D/AUL     ( 5828): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 07:23:25.868+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5828
06-04 07:23:25.938+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 07:23:25.938+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 07:23:25.938+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 07:23:25.938+0900 D/AUL_PAD ( 5828): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 07:23:28.478+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(11)[Sun, June 4][1496528608]
06-04 07:23:28.478+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(4)[7:23][1496528608]
06-04 07:23:28.478+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(2)[AM][1496528608]
06-04 07:23:28.478+0900 D/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_view_update(312) > [quickpanel_datetime_view_update : 312] update time: Sun, June 4 7&#x2236;23 AM
06-04 07:23:28.478+0900 I/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_view_update(342) > DATE STR SET: <time>7&#x2236;23</> <ampm>AM</>
06-04 07:23:28.478+0900 E/VCONF   ( 2856): vconf.c: _vconf_check_install_key_list(1135) > key : memory/pwlock/state
06-04 07:23:28.478+0900 E/VCONF   ( 2856): vconf.c: _vconf_check_retry_err(1368) > memory/pwlock/state : check retry err (-21/2).
06-04 07:23:28.478+0900 E/VCONF   ( 2856): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(memory/pwlock/state) step(-21) failed(2 / No such file or directory) retry(0) 
06-04 07:23:28.478+0900 E/VCONF   ( 2856): vconf.c: _vconf_get_key(2411) > _vconf_get_key(memory/pwlock/state) step(-21) failed(2 / No such file or directory)
06-04 07:23:28.478+0900 E/VCONF   ( 2856): vconf.c: vconf_get_int(2654) > vconf_get_int(2856) : memory/pwlock/state error
06-04 07:23:28.568+0900 E/EFL     ( 2783): <2783> e_mod_processmgr.c:481 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-04 07:23:28.568+0900 E/VCONF   ( 2856): vconf.c: _vconf_check_install_key_list(1135) > key : memory/pwlock/state
06-04 07:23:28.578+0900 E/VCONF   ( 2856): vconf.c: _vconf_check_retry_err(1368) > memory/pwlock/state : check retry err (-21/2).
06-04 07:23:28.578+0900 E/VCONF   ( 2856): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(memory/pwlock/state) step(-21) failed(2 / No such file or directory) retry(0) 
06-04 07:23:28.578+0900 E/VCONF   ( 2856): vconf.c: _vconf_get_key(2411) > _vconf_get_key(memory/pwlock/state) step(-21) failed(2 / No such file or directory)
06-04 07:23:28.578+0900 E/VCONF   ( 2856): vconf.c: vconf_get_int(2654) > vconf_get_int(2856) : memory/pwlock/state error
06-04 07:23:28.578+0900 D/AUL     ( 2856): service.c: __set_bundle(186) > __set_bundle
06-04 07:23:28.578+0900 D/AUL     ( 2856): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-04 07:23:28.578+0900 D/AUL     ( 2856): service.c: __set_bundle(186) > __set_bundle
06-04 07:23:28.578+0900 D/AUL     ( 2856): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.tizen.sfinder - no result
06-04 07:23:28.578+0900 D/AUL     ( 2856): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.tizen.sfinder
06-04 07:23:28.578+0900 D/AUL     ( 2856): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-04 07:23:28.578+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 07:23:28.578+0900 E/AUL_AMD ( 2753): amd_request.c: __request_handler(859) > no appinfo
06-04 07:23:28.578+0900 D/AUL     ( 2856): launch.c: app_request_to_launchpad(425) > launch request result : -13
06-04 07:23:28.578+0900 E/CAPI_APPFW_APP_CONTROL( 2856): app_control.c: app_control_error(143) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
06-04 07:23:28.578+0900 E/INDICATOR( 2856): util.c: util_launch_search(219) > util_launch_search[219]	 "Cannot launch app"
06-04 07:23:28.598+0900 E/QUICKPANEL( 2932): quickpanel-ui.c: _ecore_event_client_message_cb(603) > [SECURE_LOG] [_ecore_event_client_message_cb : 603] quickpanel is opened
06-04 07:23:28.598+0900 D/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_editing_icon_visibility_set(258) > [quickpanel_datetime_editing_icon_visibility_set : 258] visibility set:0
06-04 07:23:28.598+0900 D/QUICKPANEL( 2932): minictrl.c: _minictrl_opened(1155) > [_minictrl_opened : 1155] 
06-04 07:23:28.598+0900 D/QUICKPANEL( 2932): brightness.c: _qp_opened(716) > [_qp_opened : 716] quickpanel opened
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): activenoti.c: _activenoti_qp_opened(1586) > [_activenoti_qp_opened : 1586] 
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): activenoti.c: _activenoti_hide(185) > [_activenoti_hide : 185] delay : 0
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): activenoti.c: _activenoti_delete_current_noti(360) > [_activenoti_delete_current_noti : 360] There is no displaying notification
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): activenoti.c: _activenoti_hide(215) > [_activenoti_hide : 215] 
06-04 07:23:28.608+0900 E/QUICKPANEL( 2932): quickpanel-ui.c: _ecore_event_client_message_cb(579) > [SECURE_LOG] [_ecore_event_client_message_cb : 579] quickpanel is closed
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(11)[Sun, June 4][1496528608]
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(4)[7:23][1496528608]
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): util-time.c: _util_time_formatted_time_get(607) > [_util_time_formatted_time_get : 607] date:(2)[AM][1496528608]
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_view_update(312) > [quickpanel_datetime_view_update : 312] update time: Sun, June 4 7&#x2236;23 AM
06-04 07:23:28.608+0900 I/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_view_update(342) > DATE STR SET: <time>7&#x2236;23</> <ampm>AM</>
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): datetime.c: quickpanel_datetime_editing_icon_visibility_set(258) > [quickpanel_datetime_editing_icon_visibility_set : 258] visibility set:0
06-04 07:23:28.608+0900 E/EFL     ( 2932): elementary<2932> elm_scroller.c:1141 elm_scroller_page_show() The object (0x8002c161) doesn't implement the Elementary scrollable interface
06-04 07:23:28.608+0900 D/QUICKPANEL( 2932): minictrl.c: _minictrl_closed(1161) > [_minictrl_closed : 1161] 
06-04 07:23:29.038+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 07:23:29.038+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: MEM_FLUSH State: PAUSED
06-04 07:23:29.038+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 07:23:29.038+0900 D/APP_CORE( 2867): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2867
06-04 07:23:29.038+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 07:23:29.048+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2867
06-04 07:23:29.158+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:29.698+0900 I/user_tag0( 5657): /opt/usr/apps/org.example.example/data/feeding.db
06-04 07:23:29.708+0900 I/tag     ( 5657): eonji~
06-04 07:23:29.748+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:30.748+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-04 07:23:30.908+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:31.738+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:31.848+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.848+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.908+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.908+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.908+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.908+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.918+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.918+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.918+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:31.928+0900 D/IMMODULE( 5657): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 07:23:31.928+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:23:31.928+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.928+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:23:31.928+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_QUERY( 5657): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.938+0900 D/IMMODULE( 5657): scim_panel_client.cpp: open_connection(162) > 
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 07:23:31.938+0900 D/ISF_SOCKET( 5657): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:23:31.948+0900 D/IMMODULE( 5657): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 07:23:32.668+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:32.848+0900 I/tag     ( 5657): insert
06-04 07:23:32.858+0900 I/user_tag( 5657): 07:23 AM
06-04 07:23:32.858+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:32.858+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:32.868+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:32.868+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:32.868+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:33.878+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:33.958+0900 I/tag     ( 5657): �
06-04 07:23:35.258+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:35.378+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 07:23:35.378+0900 E/EFL     ( 5657): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:23:35.748+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x400bd7 bd->visible=1
06-04 07:23:35.758+0900 I/tag     ( 5657): 0
06-04 07:23:35.758+0900 I/tag     ( 5657): delete~~~
06-04 07:23:35.758+0900 I/tag     ( 5657): DELETE FROM feeding WHERE TM_HOUR = '7' AND TM_MIN = '23';
06-04 07:23:35.758+0900 I/tag     ( 5657): 0
06-04 07:23:35.758+0900 I/tag     ( 5657): 지우고~
06-04 07:23:35.768+0900 I/tag     ( 5657): 팝업 지워~
06-04 07:23:35.768+0900 I/tag     ( 5657): 끝
06-04 07:23:39.288+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:39.388+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.388+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.428+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.438+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.438+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.438+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.438+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.448+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.448+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:39.778+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 07:23:39.778+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 07:23:39.778+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 07:23:39.778+0900 E/INDICATOR( 2856): 
06-04 07:23:40.508+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:40.648+0900 I/tag     ( 5657): insert
06-04 07:23:40.648+0900 I/user_tag( 5657): 07:23 AM
06-04 07:23:40.658+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:40.658+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:40.658+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:40.668+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:40.668+0900 E/EFL     ( 5657): edje<5657> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:23:42.148+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:43.078+0900 I/user_tag0( 5657): /opt/usr/apps/org.example.example/data/feeding.db
06-04 07:23:43.078+0900 I/tag     ( 5657): eonji~
06-04 07:23:43.078+0900 I/tag     ( 5657): 들어와!
06-04 07:23:43.078+0900 I/tag     ( 5657): 언지
06-04 07:23:43.078+0900 I/tag     ( 5657): 7 23
06-04 07:23:43.078+0900 I/db      ( 5657): rd->tm_hour 7 rd->tm_min 23 
06-04 07:23:43.088+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:43.098+0900 E/EFL     ( 5657): evas_main<5657> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800d720c is not stable during recalc loop
06-04 07:23:50.448+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 07:23:50.448+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 07:23:50.448+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 07:23:50.448+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 07:23:50.468+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > battery cache is empty
06-04 07:23:50.468+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496528599 124 110 2867 1
06-04 07:23:50.468+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496528604 26 2 5657 1
06-04 07:23:53.748+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400bd7 
06-04 07:23:54.188+0900 W/CRASH_MANAGER( 5832): worker.c: worker_job(1204) > 1105657657861149652863
