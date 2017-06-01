S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 9839
Date: 2017-06-01 14:07:59+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000aa56, esi = 0xb3824590
ebp = 0xbfc059f8, esp = 0xbfc04880
eax = 0x00000000, ebx = 0xb3828000
ecx = 0xb8f43060, edx = 0xb8f43028
eip = 0xb382449b

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         7 KB
Cached:     165012 KB
VmPeak:      81144 KB
VmSize:      81144 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16220 KB
VmRSS:       16220 KB
VmData:      20056 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9839 TID = 9839
9839 9842 9879 

Maps Information
b2be5000 b2bef000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bf5000 b2c01000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c02000 b2c23000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c28000 b2c29000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c2a000 b2c2f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c30000 b2c31000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c32000 b2c34000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c35000 b2c41000 r-xp /usr/lib/libdrm.so.2.4.0
b2c42000 b2c45000 r-xp /usr/lib/libdri2.so.0.0.0
b2c46000 b2c50000 r-xp /usr/lib/libtbm.so.1.0.0
b2c51000 b2c66000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c67000 b2c79000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b347b000 b34ac000 r-xp /usr/lib/libidn.so.11.5.44
b34ad000 b34cf000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34d0000 b34e0000 r-xp /usr/lib/libcares.so.2.1.0
b34e1000 b34ea000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34eb000 b34f4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34f5000 b356c000 r-xp /usr/lib/libcurl.so.4.3.0
b356e000 b3580000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3581000 b35a2000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35a9000 b35aa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35ab000 b35ac000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35ad000 b35b0000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35b1000 b35b4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36bc000 b36c2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36c3000 b3807000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3817000 b3819000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b381a000 b381b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b381c000 b3827000 r-xp /opt/usr/apps/org.example.example/bin/example
b3829000 b3862000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4265000 b4270000 r-xp /lib/libnss_files-2.20-2014.11.so
b4272000 b427d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b427f000 b4296000 r-xp /lib/libnsl-2.20-2014.11.so
b429a000 b42a2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42a4000 b42c8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42c9000 b42ca000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42cb000 b42ce000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42cf000 b42d6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d7000 b42e1000 r-xp /usr/lib/libsensord-share.so
b42e2000 b42fe000 r-xp /usr/lib/libsensor.so.1.2.0
b4300000 b4309000 r-xp /usr/lib/libappcore-common.so.1.1
b430c000 b430e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4323000 b4325000 r-xp /usr/lib/libXau.so.6.0.0
b4326000 b4348000 r-xp /usr/lib/libxcb.so.1.1.0
b434a000 b4353000 r-xp /lib/libcrypt-2.20-2014.11.so
b437c000 b437e000 r-xp /usr/lib/libiri.so
b437f000 b43a5000 r-xp /lib/libexpat.so.1.5.2
b43a7000 b4412000 r-xp /usr/lib/libssl.so.1.0.0
b4418000 b4424000 r-xp /usr/lib/libethumb.so.1.13.0
b4425000 b4429000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b442a000 b467b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bf6000 b5c06000 r-xp /usr/lib/libXi.so.6.1.0
b5c07000 b5c09000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c0a000 b5c10000 r-xp /usr/lib/libXtst.so.6.1.0
b5c11000 b5c1b000 r-xp /usr/lib/libXrender.so.1.3.0
b5c1c000 b5c25000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c27000 b5c29000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c2a000 b5c2f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c30000 b5c42000 r-xp /usr/lib/libXext.so.6.4.0
b5c43000 b5c45000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c46000 b5c48000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c4a000 b5d8c000 r-xp /usr/lib/libX11.so.6.3.0
b5d90000 b5d9a000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d9b000 b5db1000 r-xp /usr/lib/libudev.so.1.6.0
b5db4000 b5db8000 r-xp /lib/libattr.so.1.1.0
b5db9000 b5de8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dea000 b5df0000 r-xp /usr/lib/libffi.so.6.0.2
b5df1000 b5e14000 r-xp /lib/libz.so.1.2.8
b5e15000 b5e18000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e19000 b5f75000 r-xp /usr/lib/libxml2.so.2.9.2
b5f7b000 b6062000 r-xp /usr/lib/libstdc++.so.6.0.20
b606f000 b6072000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6073000 b6095000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6096000 b60aa000 r-xp /lib/libresolv-2.20-2014.11.so
b60ae000 b60d2000 r-xp /usr/lib/liblzma.so.5.0.3
b60d3000 b60d5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60d7000 b60e1000 r-xp /usr/lib/libembryo.so.1.13.0
b60e2000 b610b000 r-xp /usr/lib/libpng12.so.0.50.0
b610c000 b6155000 r-xp /usr/lib/libjpeg.so.8.0.2
b6166000 b616d000 r-xp /lib/librt-2.20-2014.11.so
b616f000 b618e000 r-xp /usr/lib/libector.so.1.13.0
b6191000 b61be000 r-xp /usr/lib/liblua-5.1.so
b61bf000 b624f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6253000 b6291000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6292000 b62a8000 r-xp /usr/lib/libfribidi.so.0.3.1
b62a9000 b6302000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6305000 b6350000 r-xp /lib/libm-2.20-2014.11.so
b6352000 b6364000 r-xp /usr/lib/libeio.so.1.13.0
b6365000 b6368000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6369000 b636f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6370000 b6393000 r-xp /usr/lib/libefreet.so.1.13.0
b6396000 b63c1000 r-xp /usr/lib/libeldbus.so.1.13.0
b63c2000 b63f6000 r-xp /usr/lib/libecore_con.so.1.13.0
b63f8000 b6401000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6402000 b640b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b640c000 b641f000 r-xp /usr/lib/libeo.so.1.13.0
b6421000 b6434000 r-xp /usr/lib/libecore_input.so.1.13.0
b6435000 b643c000 r-xp /usr/lib/libecore_file.so.1.13.0
b643d000 b6460000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6461000 b648d000 r-xp /usr/lib/libeet.so.1.13.0
b6496000 b6501000 r-xp /usr/lib/libeina.so.1.13.0
b6504000 b651b000 r-xp /usr/lib/libefl.so.1.13.0
b651d000 b6684000 r-xp /usr/lib/libicuuc.so.51.1
b6692000 b689e000 r-xp /usr/lib/libicui18n.so.51.1
b68a6000 b68f5000 r-xp /usr/lib/libecore_x.so.1.13.0
b68f7000 b6911000 r-xp /lib/libgcc_s-4.9.so.1
b6913000 b6917000 r-xp /lib/libcap.so.2.21
b6918000 b695e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b695f000 b6966000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6968000 b69ba000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69bc000 b6b47000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b4c000 b6c1a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c1d000 b6c21000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c22000 b6c31000 r-xp /usr/lib/libvconf.so.0.2.45
b6c32000 b6c35000 r-xp /usr/lib/libvasum.so.0.3.1
b6c36000 b6c39000 r-xp /usr/lib/libttrace.so.1.1
b6c3b000 b6c3f000 r-xp /usr/lib/libiniparser.so.0
b6c40000 b6c70000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c71000 b6c7a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c7b000 b6ca0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ca1000 b6cb1000 r-xp /usr/lib/libunwind.so.8.0.1
b6cbb000 b6e69000 r-xp /lib/libc-2.20-2014.11.so
b6e71000 b6fb4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fb6000 b700e000 r-xp /usr/lib/libdbus-1.so.3.8.11
b700f000 b7043000 r-xp /usr/lib/libsystemd.so.0.4.0
b7046000 b711a000 r-xp /usr/lib/libedje.so.1.13.0
b711d000 b7149000 r-xp /usr/lib/libecore.so.1.13.0
b715a000 b7380000 r-xp /usr/lib/libevas.so.1.13.0
b73a8000 b73c0000 r-xp /lib/libpthread-2.20-2014.11.so
b73c4000 b773e000 r-xp /usr/lib/libelementary.so.1.13.0
b775e000 b7762000 r-xp /usr/lib/libsmack.so.1.0.0
b7763000 b776c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b776d000 b7770000 r-xp /usr/lib/libdlog.so.0.0.0
b7771000 b7776000 r-xp /usr/lib/libbundle.so.0.1.22
b7777000 b777a000 r-xp /lib/libdl-2.20-2014.11.so
b777c000 b77a1000 r-xp /usr/lib/libaul.so.0.1.0
b77a4000 b77a6000 r-xp /usr/lib/libappsvc.so.0.1.0
b77a7000 b77ac000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77ad000 b77b4000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b6000 b77bb000 r-xp /usr/lib/libsys-assert.so
b77be000 b77bf000 r-xp [vdso]
b77bf000 b77e1000 r-xp /lib/ld-2.20-2014.11.so
b77e3000 b77eb000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:9839)
Call Stack Count: 8
 0: create_base_gui + 0xc1b (0xb382449b) [/opt/usr/apps/org.example.example/bin/example] + 0x849b
 1: app_create + 0x2c (0xb38236ec) [/opt/usr/apps/org.example.example/bin/example] + 0x76ec
 2: (0xb77a965b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
 3: appcore_efl_main + 0x327 (0xb77b0c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 4: ui_app_main + 0x140 (0xb77a9c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 5: main + 0x2e1 (0xb3823661) [/opt/usr/apps/org.example.example/bin/example] + 0x7661
 6: (0xb77e5148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77e5148
 7: __libc_start_main + 0xde (0xb6cd2e4e) [/lib/libc.so.6] + 0x17e4e
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
_LOG] number of alarms of the process (pid:2935, unique_name:/usr/bin/starter) is 0.
06-01 14:07:55.491+0900 D/eventsystem( 2778): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
06-01 14:07:55.491+0900 D/eventsystem( 2778): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
06-01 14:07:55.491+0900 D/eventsystem( 2778): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
06-01 14:07:55.501+0900 D/ALARM_MANAGER( 2935): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
06-01 14:07:55.501+0900 D/ALARM_MANAGER( 2935): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
06-01 14:07:55.501+0900 D/eventsystem( 2778): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
06-01 14:07:55.501+0900 D/eventsystem( 2778): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
06-01 14:07:55.501+0900 D/ALARM_MANAGER( 2885): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2935]
06-01 14:07:55.501+0900 D/INDICATOR( 2934): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
06-01 14:07:55.501+0900 D/ALARM_MANAGER( 2885): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2935]
06-01 14:07:55.501+0900 E/ALARM_MANAGER( 2885): alarm-manager.c: _get_zone_name(573) > zone name [/]
06-01 14:07:55.501+0900 E/ALARM_MANAGER( 2885): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2935), but max_number_of_ids(0) is less than 0.
06-01 14:07:55.501+0900 D/ALARM_MANAGER( 2935): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
06-01 14:07:55.511+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 14:07:55.521+0900 D/APP_CORE( 2945): appcore-rotation.c: __changed_cb(121) > [APP 2945] Rotation: 1 -> 1
06-01 14:07:55.681+0900 D/LAUNCH  ( 9847): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
06-01 14:07:55.681+0900 D/PKGMGR_INFO( 9847): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 14:07:55.681+0900 D/PKGMGR_INFO( 9847): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 14:07:55.701+0900 D/AUL     ( 9847): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 9847 is org.tizen.crash-popup
06-01 14:07:55.781+0900 D/STARTER ( 2935): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86PowerOff Released
06-01 14:07:55.781+0900 D/STARTER ( 2935): hw_key.c: _key_release_cb(233) > [_key_release_cb:233] phone lock state, ignore home key.
06-01 14:07:55.931+0900 D/STARTER ( 2935): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8f2f8c8), lock_pid(9649)
06-01 14:07:55.941+0900 E/STARTER ( 2935): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
06-01 14:07:55.951+0900 D/APP_CORE( 9847): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:07:55.951+0900 D/APP_CORE( 9847): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
06-01 14:07:55.951+0900 D/APP_CORE( 9847): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:07:55.961+0900 D/APP_CORE( 9847): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:07:55.961+0900 D/APP_CORE( 9847): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7772520
06-01 14:07:55.971+0900 D/LAUNCH  ( 9847): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
06-01 14:07:55.971+0900 D/STARTER ( 2935): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8f2f8c8), lock_pid(9649)
06-01 14:07:55.981+0900 D/STARTER ( 2935): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8f2f8c8), lock_pid(9649)
06-01 14:07:56.011+0900 D/STARTER ( 2935): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8f2f8c8), lock_pid(9649)
06-01 14:07:56.021+0900 D/APP_CORE( 9847): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:07:56.041+0900 D/LAUNCH  ( 9847): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
06-01 14:07:56.041+0900 D/APP_CORE( 9847): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 14:07:56.071+0900 D/STARTER ( 2935): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8f2f8c8), lock_pid(9649)
06-01 14:07:56.071+0900 E/STARTER ( 2935): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
06-01 14:07:56.081+0900 W/E17_EXTRA_MODULES( 2741): e_mod_comp.c: _e_mod_comp_win_add(1727) > [CW Creating Fail!!(Attributes get)] Win:02c00002, BD:(nil), POP:(nil), MENU:(nil)
06-01 14:07:56.191+0900 E/RESOURCED( 2893): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
06-01 14:07:56.501+0900 D/LOCKSCREEN( 9649): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
06-01 14:07:56.501+0900 D/LOCKSCREEN( 9649): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(181), y(763)
06-01 14:07:56.501+0900 D/LOCKSCREEN( 9649): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
06-01 14:07:56.501+0900 D/LOCKSCREEN( 9649): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
06-01 14:07:56.651+0900 D/LOCKSCREEN( 9649): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
06-01 14:07:56.671+0900 D/LOCKSCREEN( 9649): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496293676) formatted(Thu, June 1)
06-01 14:07:56.671+0900 D/LOCKSCREEN( 9649): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496293676) formatted(2:07)
06-01 14:07:56.671+0900 D/LOCKSCREEN( 9649): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496293676) formatted(PM)
06-01 14:07:56.671+0900 I/LOCKSCREEN( 9649): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
06-01 14:07:56.741+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x2010a7 
06-01 14:07:57.171+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.171+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/LOCKSCREEN( 9649): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-01 14:07:57.181+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: ui_app_exit(799) > ui_app_exit
06-01 14:07:57.181+0900 D/AUL     ( 9649): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-01 14:07:57.181+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 22
06-01 14:07:57.181+0900 W/AUL_AMD ( 2858): amd_request.c: __request_handler(1056) > app status : 5
06-01 14:07:57.181+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(9649) status(5)
06-01 14:07:57.181+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(9649) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
06-01 14:07:57.181+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
06-01 14:07:57.181+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9649, appid: org.tizen.lockscreen, status: bg
06-01 14:07:57.191+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 9649, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
06-01 14:07:57.191+0900 D/RESOURCED( 2893): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 9649, appname = org.tizen.lockscreen
06-01 14:07:57.191+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 9649
06-01 14:07:57.191+0900 D/RESOURCED( 2893): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2941 increase lru 5
06-01 14:07:57.191+0900 D/RESOURCED( 2893): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2941 set score 420 (before 390)
06-01 14:07:57.191+0900 D/RESOURCED( 2893): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
06-01 14:07:57.191+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9649, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
06-01 14:07:57.191+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 9649
06-01 14:07:57.191+0900 D/APP_CORE( 9649): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-01 14:07:57.191+0900 I/CAPI_APPFW_APPLICATION( 9649): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-01 14:07:57.191+0900 D/LOCKSCREEN( 9649): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
06-01 14:07:57.201+0900 D/COM_CORE( 9649): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
06-01 14:07:57.201+0900 D/COM_CORE( 9649): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
06-01 14:07:57.201+0900 D/COM_CORE( 9649): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
06-01 14:07:57.201+0900 D/COM_CORE( 3009): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-01 14:07:57.201+0900 D/DATA_PROVIDER_MASTER( 3009): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2a00540 is terminated
06-01 14:07:57.201+0900 D/DATA_PROVIDER_MASTER( 3009): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-01 14:07:57.241+0900 E/COM_CORE( 9649): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
06-01 14:07:57.241+0900 E/LOCKSCREEN( 9649): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
06-01 14:07:57.241+0900 E/LOCKSCREEN( 9649): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
06-01 14:07:57.241+0900 D/LOCKSCREEN( 9649): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
06-01 14:07:57.241+0900 D/CALL_MGR_CLIENT( 9649): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
06-01 14:07:57.241+0900 D/CALL_MGR_CLIENT( 9649): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
06-01 14:07:57.241+0900 W/CALL_MGR_CLIENT( 9649): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
06-01 14:07:57.241+0900 D/CALL_MGR_CLIENT( 9649): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
06-01 14:07:57.241+0900 D/CALL_MGR_CLIENT( 9649): <LIB:cm_deinit:444> cm_deinit
06-01 14:07:57.241+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
06-01 14:07:57.251+0900 D/SYSTEM-SETTINGS( 9649): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
06-01 14:07:57.251+0900 D/SYSTEM-SETTINGS( 9649): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
06-01 14:07:57.251+0900 D/SYSTEM-SETTINGS( 9649): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
06-01 14:07:57.251+0900 D/LOCKSCREEN( 9649): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
06-01 14:07:57.251+0900 D/SYSTEM-SETTINGS( 9649): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
06-01 14:07:57.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9649): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
06-01 14:07:57.251+0900 D/SYSTEM-SETTINGS( 9649): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
06-01 14:07:57.271+0900 D/LOCKSCREEN( 9649): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
06-01 14:07:57.271+0900 E/EFL     ( 9649): eo<9649> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
06-01 14:07:57.271+0900 E/EFL     ( 9649): eo<9649> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
06-01 14:07:57.591+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x02800007), visible:1
06-01 14:07:57.591+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 14:07:57.611+0900 E/E17_TZSH( 2741): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b3a175c0, role:118
06-01 14:07:57.651+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2945
06-01 14:07:57.651+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
06-01 14:07:57.661+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 2800007
06-01 14:07:57.661+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-01 14:07:57.671+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 14:07:57.671+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 14:07:57.671+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 14:07:57.671+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 14:07:57.681+0900 I/TZSH    ( 3014): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
06-01 14:07:57.681+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 14:07:57.691+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 14:07:57.691+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-01 14:07:57.691+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-01 14:07:57.691+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2945 is org.tizen.homescreen
06-01 14:07:57.691+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2945 : 0
06-01 14:07:57.701+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 14:07:57.701+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: RESUME State: PAUSED
06-01 14:07:57.701+0900 D/LAUNCH  ( 2945): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 14:07:57.701+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(607) > [APP 2945] RESUME
06-01 14:07:57.701+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 14:07:57.701+0900 E/cluster-home( 2945): homescreen.cpp: OnResume(66) >  app resume
06-01 14:07:57.701+0900 D/cluster-home( 2945): widget-data-provider.cpp: SetBoxVisibility(1543) >  
06-01 14:07:57.701+0900 D/cluster-home( 2945): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
06-01 14:07:57.701+0900 D/WIDGET_VIEWER( 2945): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
06-01 14:07:57.701+0900 D/cluster-home( 2945): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
06-01 14:07:57.701+0900 D/cluster-home( 2945): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
06-01 14:07:57.711+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
06-01 14:07:57.711+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppResume(910) >  END
06-01 14:07:57.711+0900 D/cluster-view( 2945): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-01 14:07:57.711+0900 D/cluster-view( 2945): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-01 14:07:57.711+0900 D/cluster-view( 2945): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
06-01 14:07:57.711+0900 D/cluster-view( 2945): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
06-01 14:07:57.711+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
06-01 14:07:57.711+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
06-01 14:07:57.711+0900 D/test-log( 2945): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
06-01 14:07:57.711+0900 D/test-log( 2945): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-01 14:07:57.711+0900 D/cluster-view( 2945): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
06-01 14:07:57.711+0900 D/cluster-home( 2945): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
06-01 14:07:57.711+0900 D/LAUNCH  ( 2945): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
06-01 14:07:57.711+0900 D/LAUNCH  ( 2945): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
06-01 14:07:57.711+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 14:07:57.711+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 14:07:57.721+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2945 is resumed
06-01 14:07:57.721+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
06-01 14:07:57.721+0900 E/DATA_PROVIDER_MASTER( 3009): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
06-01 14:07:57.741+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
06-01 14:07:57.741+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
06-01 14:07:57.741+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: fg
06-01 14:07:57.741+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3084
06-01 14:07:57.741+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
06-01 14:07:57.741+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3084
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:07:57.781+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:07:57.781+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 9649 pgid = 9649
06-01 14:07:57.781+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(9649)
06-01 14:07:57.801+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 14:07:57.801+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 14:07:57.801+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 14:07:57.801+0900 E/AUL_PAD ( 3003): launchpad.c: main(688) > error reading sigchld info
06-01 14:07:57.821+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 9649 is termianted
06-01 14:07:57.821+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
06-01 14:07:57.821+0900 E/STARTER ( 2935): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
06-01 14:07:57.821+0900 D/STARTER ( 2935): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
06-01 14:07:57.821+0900 D/STARTER ( 2935): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
06-01 14:07:57.821+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 9649
06-01 14:07:57.821+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 9649
06-01 14:07:57.821+0900 D/AUL_AMD ( 2858): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 14:07:57.821+0900 E/AUL_AMD ( 2858): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 14:07:57.821+0900 D/AUL_AMD ( 2858): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
06-01 14:07:57.821+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:07:57.821+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:07:57.821+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3084, appname = org.tizen.calendar.widget
06-01 14:07:57.821+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3084
06-01 14:07:57.821+0900 W/STARTER ( 2935): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x2800007 is not transient
06-01 14:07:57.821+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.799
06-01 14:07:57.821+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 14:07:57.821+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 14:07:57.821+0900 I/ESD     ( 3017): esd_main.c: __esd_app_dead_handler(1771) > pid: 9649
06-01 14:07:57.831+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 9649
06-01 14:07:57.841+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
06-01 14:07:57.841+0900 D/VOLUME  ( 2941): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
06-01 14:07:57.841+0900 D/INDICATOR( 2934): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
06-01 14:07:57.901+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(9655) status(4)
06-01 14:07:57.991+0900 D/cluster-view( 2945): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
06-01 14:07:57.991+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
06-01 14:07:57.991+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
06-01 14:07:57.991+0900 D/test-log( 2945): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
06-01 14:07:57.991+0900 D/test-log( 2945): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-01 14:07:57.991+0900 D/cluster-view( 2945): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
06-01 14:07:57.991+0900 D/cluster-home( 2945): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
06-01 14:07:59.071+0900 E/EFL     ( 9847): eldbus<9847> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-9FKz4Ir6EP: Connection refused
06-01 14:07:59.071+0900 E/EFL     ( 9847): <9847> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
06-01 14:07:59.071+0900 E/EFL     ( 9847): elementary<9847> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
06-01 14:07:59.071+0900 D/APP_CORE( 9847): appcore.c: __aul_handler(587) > [APP 9847]     AUL event: AUL_START
06-01 14:07:59.071+0900 I/APP_CORE( 9847): appcore-efl.c: __do_app(496) > [APP 9847] Event: RESET State: CREATED
06-01 14:07:59.071+0900 D/APP_CORE( 9847): appcore-efl.c: __do_app(527) > [APP 9847] RESET
06-01 14:07:59.071+0900 D/LAUNCH  ( 9847): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-01 14:07:59.071+0900 D/APP_CORE( 9847): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 14:07:59.071+0900 D/APP_CORE( 9847): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 14:07:59.071+0900 E/SYSPOPUP( 9847): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 14:07:59.071+0900 E/SYSPOPUP( 9847): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 14:07:59.071+0900 E/SYSPOPUP( 9847): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-01 14:07:59.071+0900 D/LAUNCH  ( 9847): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-01 14:07:59.071+0900 D/APP_CORE( 9847): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 14:07:59.151+0900 D/AUL     ( 9847): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-01 14:07:59.161+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 22
06-01 14:07:59.161+0900 W/AUL_AMD ( 2858): amd_request.c: __request_handler(1056) > app status : 5
06-01 14:07:59.161+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(9847) status(5)
06-01 14:07:59.161+0900 D/APP_CORE( 9847): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-01 14:07:59.161+0900 E/EFL     ( 9847): eo<9847> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-01 14:07:59.161+0900 E/EFL     ( 9847): eo<9847> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-01 14:07:59.481+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
06-01 14:07:59.481+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
06-01 14:07:59.631+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
06-01 14:07:59.631+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
06-01 14:07:59.631+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
06-01 14:07:59.631+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
06-01 14:07:59.631+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[467.00][363.00] to[467.00][363.00]!
06-01 14:07:59.631+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
06-01 14:07:59.641+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [47]MenuBox clicked
06-01 14:07:59.641+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200050 
06-01 14:07:59.641+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
06-01 14:07:59.641+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 14:07:59.641+0900 D/AUL     ( 2945): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-01 14:07:59.641+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 14:07:59.641+0900 D/AUL     ( 2945): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
06-01 14:07:59.641+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
06-01 14:07:59.641+0900 D/AUL     ( 2945): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-01 14:07:59.651+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 14:07:59.651+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 14:07:59.651+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
06-01 14:07:59.651+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 2945
06-01 14:07:59.681+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2443) > win(c00002) ecore_x_pointer_grab(1)
06-01 14:07:59.681+0900 D/AUL_AMD ( 2858): amd_key.c: _key_grab(243) > _key_grab, win : c00002
06-01 14:07:59.701+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2448) > back key grab
06-01 14:07:59.701+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 14:07:59.711+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 14:07:59.711+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 14:07:59.711+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 14:07:59.711+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 14:07:59.711+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 14:07:59.711+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 14:07:59.711+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 14:07:59.711+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 884 / 884
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9839, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 14:07:59.711+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 14:07:59.711+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 14:07:59.711+0900 D/AUL     ( 9839): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9842) is sent.
06-01 14:07:59.711+0900 D/AUL     ( 9839): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9842, signo: 10
06-01 14:07:59.711+0900 D/AUL     ( 9839): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyOTM2NzkvNjYwMDY0AA==##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTQ1AA==##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 14:07:59.711+0900 D/AUL_PAD ( 9839): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 14:07:59.711+0900 I/CAPI_APPFW_APPLICATION( 9839): app_main.c: ui_app_main(788) > app_efl_main
06-01 14:07:59.711+0900 D/LAUNCH  ( 9839): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 14:07:59.711+0900 D/APP_CORE( 9839): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 14:07:59.711+0900 D/APP_CORE( 9839): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 14:07:59.711+0900 D/APP_CORE( 9839): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 14:07:59.761+0900 D/APP_CORE( 9839): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 14:07:59.761+0900 D/AUL     ( 9839): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 14:07:59.761+0900 D/APP_CORE( 9839): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4309520
06-01 14:07:59.761+0900 D/LAUNCH  ( 9839): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 14:07:59.761+0900 I/CAPI_APPFW_APPLICATION( 9839): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 14:07:59.811+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 14:07:59.811+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9839, appid: org.example.example
06-01 14:07:59.811+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 14:07:59.811+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 14:07:59.811+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 14:07:59.811+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 14:07:59.811+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(9839) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 14:07:59.811+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(425) > launch request result : 9839
06-01 14:07:59.811+0900 E/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
06-01 14:07:59.811+0900 D/test-log( 2945): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
06-01 14:07:59.811+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 9839
06-01 14:07:59.811+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 14:07:59.811+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 14:07:59.811+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 317
06-01 14:07:59.931+0900 W/CRASH_MANAGER( 9827): worker.c: worker_job(1204) > 1109839657861149629367
