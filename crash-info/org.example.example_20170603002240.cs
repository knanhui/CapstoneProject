S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7780
Date: 2017-06-03 00:22:40+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7780, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3e90000, r3   = 0xb3e90020
r4   = 0x8001b2da, r5   = 0xbea502a0
r6   = 0xb27799a5, r7   = 0xbea50128
r8   = 0x8001b2da, r9   = 0xb5e72708
r10  = 0xb76bf588, fp   = 0xbea5027c
ip   = 0xb5f62120, sp   = 0xbea500e8
lr   = 0xb5f26bd9, pc   = 0xb27799ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     39104 KB
Buffers:     17008 KB
Cached:     111492 KB
VmPeak:     110064 KB
VmSize:     108580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24188 KB
VmRSS:       24188 KB
VmData:      34512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7780 TID = 7780
7780 7781 7838 7842 

Maps Information
b1274000 b1a73000 rw-p [stack:7842]
b1aef000 b1af7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b08000 b1b09000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b19000 b1b2d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b41000 b1b42000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b52000 b1b55000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b66000 b1b67000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b77000 b1b79000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1b89000 b1b8b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1b9b000 b1bab000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bbb000 b1bc7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bd9000 b23d8000 rw-p [stack:7838]
b2709000 b2710000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2721000 b2729000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2739000 b274e000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2760000 b2766000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2776000 b277e000 r-xp /opt/usr/apps/org.example.example/bin/example
b28d6000 b29b9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29f0000 b2a18000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a2a000 b3229000 rw-p [stack:7781]
b3229000 b322b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b323b000 b3245000 r-xp /lib/libnss_files-2.20-2014.11.so
b3256000 b325f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3270000 b3281000 r-xp /lib/libnsl-2.20-2014.11.so
b3294000 b329a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ab000 b32ac000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d4000 b32db000 r-xp /usr/lib/libminizip.so.1.0.0
b32eb000 b32f0000 r-xp /usr/lib/libstorage.so.0.1
b3300000 b335f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3375000 b3389000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3399000 b33dd000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ed000 b33f5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3405000 b3435000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3448000 b3501000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3515000 b3568000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3579000 b3594000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a4000 b3665000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3678000 b3688000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3698000 b36a5000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b6000 b36bd000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36cd000 b370e000 r-xp /usr/lib/libmdm.so.1.2.12
b371e000 b3726000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3735000 b3745000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3766000 b37c6000 r-xp /usr/lib/libasound.so.2.0.0
b37d8000 b37db000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37eb000 b37ee000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fe000 b3803000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3813000 b3814000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3824000 b382f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3843000 b384a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b385a000 b3860000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3870000 b3875000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3885000 b38a0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38b0000 b38b7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c7000 b38ca000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38db000 b3909000 r-xp /usr/lib/libidn.so.11.5.44
b3919000 b392f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3940000 b394a000 r-xp /usr/lib/libcares.so.2.1.0
b395a000 b3964000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3974000 b3976000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3986000 b3987000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3997000 b399b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ac000 b39d4000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e5000 b3a0e000 r-xp /usr/lib/libturbojpeg.so
b3a2e000 b3a34000 r-xp /usr/lib/libgif.so.4.1.6
b3a44000 b3a8a000 r-xp /usr/lib/libcurl.so.4.3.0
b3a9b000 b3abc000 r-xp /usr/lib/libexif.so.12.3.3
b3ad7000 b3aec000 r-xp /usr/lib/libtts.so
b3afd000 b3b05000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b15000 b3bdb000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bfb000 b3cf3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d12000 b3de0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df7000 b3df9000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e09000 b3e0f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1f000 b3e42000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e53000 b3e55000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e65000 b3e67000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e78000 b3e7d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e94000 b3e96000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea6000 b3ead000 r-xp /usr/lib/libsensord-share.so
b3ebd000 b3ed5000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee6000 b3ee9000 r-xp /usr/lib/libXv.so.1.0.0
b3ef9000 b3efe000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0e000 b3f13000 r-xp /usr/lib/libappcore-common.so.1.1
b3f23000 b3f2a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3d000 b3f41000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f52000 b4030000 r-xp /usr/lib/libCOREGL.so.4.0
b4050000 b4053000 r-xp /usr/lib/libuuid.so.1.3.0
b4063000 b407a000 r-xp /usr/lib/libblkid.so.1.1.0
b408b000 b408d000 r-xp /usr/lib/libXau.so.6.0.0
b409d000 b40e4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f6000 b40fc000 r-xp /usr/lib/libjson-c.so.2.0.1
b410d000 b4111000 r-xp /usr/lib/libogg.so.0.7.1
b4121000 b4143000 r-xp /usr/lib/libvorbis.so.0.4.3
b4153000 b4237000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4253000 b4256000 r-xp /usr/lib/libEGL.so.1.4
b4267000 b426d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427d000 b427f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428f000 b429c000 r-xp /usr/lib/libGLESv2.so.2.0
b42ad000 b430f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4324000 b433c000 r-xp /usr/lib/libmount.so.1.1.0
b434e000 b4362000 r-xp /usr/lib/libxcb.so.1.1.0
b4372000 b4379000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b1000 b43b3000 r-xp /usr/lib/libiri.so
b43c3000 b43ce000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43df000 b4415000 r-xp /usr/lib/libpulse.so.0.16.2
b4426000 b4469000 r-xp /usr/lib/libsndfile.so.1.0.25
b447e000 b4493000 r-xp /lib/libexpat.so.1.5.2
b44a5000 b4563000 r-xp /usr/lib/libcairo.so.2.11200.14
b4577000 b457f000 r-xp /usr/lib/libdrm.so.2.4.0
b458f000 b4592000 r-xp /usr/lib/libdri2.so.0.0.0
b45a2000 b45f0000 r-xp /usr/lib/libssl.so.1.0.0
b4605000 b4611000 r-xp /usr/lib/libeeze.so.1.13.0
b4622000 b462b000 r-xp /usr/lib/libethumb.so.1.13.0
b463b000 b463e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464e000 b4805000 r-xp /usr/lib/libcrypto.so.1.0.0
b55f0000 b55f9000 r-xp /usr/lib/libXi.so.6.1.0
b5609000 b560b000 r-xp /usr/lib/libXgesture.so.7.0.0
b561b000 b561f000 r-xp /usr/lib/libXtst.so.6.1.0
b562f000 b5635000 r-xp /usr/lib/libXrender.so.1.3.0
b5645000 b564b000 r-xp /usr/lib/libXrandr.so.2.2.0
b565b000 b565d000 r-xp /usr/lib/libXinerama.so.1.0.0
b566e000 b5671000 r-xp /usr/lib/libXfixes.so.3.1.0
b5681000 b568c000 r-xp /usr/lib/libXext.so.6.4.0
b569c000 b569e000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ae000 b56b0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56c0000 b57a2000 r-xp /usr/lib/libX11.so.6.3.0
b57b6000 b57bd000 r-xp /usr/lib/libXcursor.so.1.0.2
b57cd000 b57e5000 r-xp /usr/lib/libudev.so.1.6.0
b57e7000 b57ea000 r-xp /lib/libattr.so.1.1.0
b57fa000 b581a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b581b000 b5820000 r-xp /usr/lib/libffi.so.6.0.2
b5831000 b5849000 r-xp /lib/libz.so.1.2.8
b5859000 b585b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b586b000 b5940000 r-xp /usr/lib/libxml2.so.2.9.2
b5955000 b59f0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a0c000 b5a0f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1f000 b5a38000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a49000 b5a5a000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6e000 b5ae8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afd000 b5aff000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0f000 b5b16000 r-xp /usr/lib/libembryo.so.1.13.0
b5b26000 b5b30000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b41000 b5b59000 r-xp /usr/lib/libpng12.so.0.50.0
b5b6a000 b5b8d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bae000 b5bc2000 r-xp /usr/lib/libector.so.1.13.0
b5bd3000 b5beb000 r-xp /usr/lib/liblua-5.1.so
b5bfc000 b5c53000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c67000 b5c8f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca0000 b5cb3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc4000 b5cfe000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0f000 b5d1d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2d000 b5d35000 r-xp /usr/lib/libtbm.so.1.0.0
b5d45000 b5d52000 r-xp /usr/lib/libeio.so.1.13.0
b5d62000 b5d64000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d74000 b5d79000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d89000 b5da0000 r-xp /usr/lib/libefreet.so.1.13.0
b5db2000 b5dd2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de2000 b5e02000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e04000 b5e0a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e1a000 b5e2b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3c000 b5e43000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e53000 b5e62000 r-xp /usr/lib/libeo.so.1.13.0
b5e73000 b5e85000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e96000 b5e9b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eab000 b5ec4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed4000 b5ef1000 r-xp /usr/lib/libeet.so.1.13.0
b5f0a000 b5f52000 r-xp /usr/lib/libeina.so.1.13.0
b5f63000 b5f73000 r-xp /usr/lib/libefl.so.1.13.0
b5f84000 b6069000 r-xp /usr/lib/libicuuc.so.51.1
b6086000 b61c6000 r-xp /usr/lib/libicui18n.so.51.1
b61dd000 b6215000 r-xp /usr/lib/libecore_x.so.1.13.0
b6227000 b622a000 r-xp /lib/libcap.so.2.21
b623a000 b6263000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6274000 b627b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628d000 b62c4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d5000 b63c0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d3000 b644c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645e000 b6463000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6473000 b647d000 r-xp /usr/lib/libvconf.so.0.2.45
b648d000 b648f000 r-xp /usr/lib/libvasum.so.0.3.1
b649f000 b64a1000 r-xp /usr/lib/libttrace.so.1.1
b64b1000 b64b4000 r-xp /usr/lib/libiniparser.so.0
b64c4000 b64ea000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64fa000 b64ff000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6510000 b6527000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6538000 b65a3000 r-xp /lib/libm-2.20-2014.11.so
b65b4000 b65ba000 r-xp /lib/librt-2.20-2014.11.so
b65cb000 b65d8000 r-xp /usr/lib/libunwind.so.8.0.1
b660e000 b6732000 r-xp /lib/libc-2.20-2014.11.so
b6747000 b6760000 r-xp /lib/libgcc_s-4.9.so.1
b6770000 b6852000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6863000 b688d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689e000 b68da000 r-xp /usr/lib/libsystemd.so.0.4.0
b68dc000 b695f000 r-xp /usr/lib/libedje.so.1.13.0
b6972000 b6990000 r-xp /usr/lib/libecore.so.1.13.0
b69b0000 b6b37000 r-xp /usr/lib/libevas.so.1.13.0
b6b6c000 b6b80000 r-xp /lib/libpthread-2.20-2014.11.so
b6b94000 b6dc8000 r-xp /usr/lib/libelementary.so.1.13.0
b6df7000 b6dfb000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0b000 b6e12000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e22000 b6e24000 r-xp /usr/lib/libdlog.so.0.0.0
b6e34000 b6e37000 r-xp /usr/lib/libbundle.so.0.1.22
b6e47000 b6e49000 r-xp /lib/libdl-2.20-2014.11.so
b6e5a000 b6e72000 r-xp /usr/lib/libaul.so.0.1.0
b6e86000 b6e8b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9c000 b6ea9000 r-xp /usr/lib/liblptcp.so
b6ebb000 b6ebf000 r-xp /usr/lib/libsys-assert.so
b6ed0000 b6ef0000 r-xp /lib/ld-2.20-2014.11.so
b6f01000 b6f06000 r-xp /usr/bin/launchpad-loader
b7454000 b770d000 rw-p [heap]
bea30000 bea51000 rw-p [stack]
bea30000 bea51000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7780)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb27799ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb69e5175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5e5e219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e5cfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb69e5515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb69ed725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb69f2f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb69f6939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb463d173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb697dc4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6983a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6983c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6e892bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f3f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb277b673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f02bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66244bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f02eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
ncoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:22:20.334+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.334+0900 E/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:22:20.334+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.344+0900 E/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:22:20.344+0900 E/weather-agent( 7756): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:22:20.344+0900 E/weather-agent( 7756): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 7756): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 7756): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:22:20.344+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.364+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:22:20.364+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:22:20.364+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:20.384+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.384+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:22:20.394+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:22:20.434+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:22:20.474+0900 W/LFE      (15849): [15849] 26:16:52.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:20.494+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:22:20.504+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:22:20.715+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127520716
06-03 00:22:20.855+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127520857
06-03 00:22:20.855+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:22:20.855+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:22:20.855+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:22:20.865+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:22:21.195+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:22:21.205+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:22:21.205+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:22:21.215+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.225+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:22:21.225+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:22:21.225+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:22:21.225+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.235+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(3)
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:22:21.235+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESUME State: PAUSED
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:22:21.235+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:22:21.235+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:22:21.235+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:21.245+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:22:21.255+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:22:21.255+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:22:21.255+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7473)
06-03 00:22:21.255+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: fg
06-03 00:22:21.285+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:22:21.285+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:22:21.285+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.295+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.315+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:22:21.345+0900 E/weather-agent( 7756): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:22:21.345+0900 I/CAPI_APPFW_APPLICATION( 7756): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:22:21.345+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:22:21.345+0900 E/weather-agent( 7756): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:22:21.345+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:22:21.395+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:22:21.475+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:22:21.485+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7756
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7756] terminate event is forwarded
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7756, ]
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:22:21.485+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7756
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (512) > Not registered pid(7756)
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:22:21.485+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7756.
06-03 00:22:21.686+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127521682
06-03 00:22:21.816+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074736578611496416941
06-03 00:22:21.846+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7473] terminate event is forwarded
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7473, ]
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (512) > Not registered pid(7473)
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:22:21.846+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7473
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7473
06-03 00:22:21.846+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7473
06-03 00:22:21.856+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:22:21.856+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:22:21.876+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:22:21.876+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:22:21.876+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:22:21.856+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.876+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:22:21.876+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7473.
06-03 00:22:21.886+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:22:21.936+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.936+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:22:21.936+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:21.936+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:22:21.946+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:21.946+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.976+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:22:21.976+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:22:21.976+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.986+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.986+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:22:21.986+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:22:21.986+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:22:21.986+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:22:21.996+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:22.076+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:22:22.086+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:22:22.967+0900 W/LFE      (15849): [15849] 26:16:55.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:23.918+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127523923
06-03 00:22:23.998+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127523999
06-03 00:22:23.998+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:22:23.998+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:22:23.998+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:22:24.008+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:22:24.008+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:22:24.018+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:22:24.018+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:22:24.018+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:22:24.038+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:22:24.038+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:22:24.068+0900 E/TBM     ( 7470): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:22:24.118+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7470, appid: org.example.example
06-03 00:22:24.118+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:22:24.118+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7470)
06-03 00:22:24.248+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(514) > [APP 7470] Event: RESET State: CREATED
06-03 00:22:24.248+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:22:24.248+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.248+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:24.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:24.308+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:22:24.318+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:24.318+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:24.328+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:24.358+0900 W/APP_CORE( 7470): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:22:24.358+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:22:24.458+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:22:24.458+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:22:24.458+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:22:24.458+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:22:24.458+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:22:24.458+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:22:24.458+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7470) status(3)
06-03 00:22:24.468+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7470)
06-03 00:22:24.468+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7470, appid: org.example.example, status: fg
06-03 00:22:24.478+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:22:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:22:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:22:24.488+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:22:24.508+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(514) > [APP 7470] Event: RESUME State: CREATED
06-03 00:22:24.518+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:22:24.518+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(625) > [APP 7470] Initial Launching, call the resume_cb
06-03 00:22:24.518+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:24.829+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7470) status(0)
06-03 00:22:25.149+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3247
06-03 00:22:25.159+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:22:25.159+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7470.
06-03 00:22:25.459+0900 W/LFE      (15849): [15849] 26:16:57.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:25.940+0900 I/UXT     ( 7780): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:22:26.240+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:22:26.340+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:22:27.932+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127527929
06-03 00:22:27.972+0900 W/LFE      (15849): [15849] 26:17:00.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:27.982+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127527983
06-03 00:22:29.473+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:22:30.474+0900 W/LFE      (15849): [15849] 26:17:02.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:30.995+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:22:31.315+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127531313
06-03 00:22:31.485+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074706578611496416951
06-03 00:22:31.505+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7470 pgid = 7470
06-03 00:22:31.505+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7470)
06-03 00:22:31.505+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:31.515+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:22:31.515+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:22:31.515+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:22:31.515+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:22:31.515+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:22:31.575+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:22:31.575+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:22:31.575+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:22:31.575+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7470
06-03 00:22:31.575+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7470] terminate event is forwarded
06-03 00:22:31.575+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:22:31.575+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7470, ]
06-03 00:22:31.575+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:22:31.575+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:22:31.575+0900 I/Tizen::App( 1210): (512) > Not registered pid(7470)
06-03 00:22:31.575+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:22:31.575+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:31.575+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7470
06-03 00:22:31.575+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7470
06-03 00:22:31.585+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3250
06-03 00:22:31.595+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:22:31.605+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:22:31.605+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:31.605+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:22:31.605+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:22:31.605+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:31.615+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:22:31.625+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:31.625+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7470.
06-03 00:22:31.635+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:22:31.635+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:31.645+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:22:31.645+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:22:31.645+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:31.645+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:31.645+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:31.655+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:31.655+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:22:31.665+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:31.665+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:22:31.665+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:22:31.665+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:22:31.665+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:22:31.685+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:22:31.685+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:22:31.685+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:22:31.685+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:22:31.695+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:31.765+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:22:31.775+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:22:32.967+0900 W/LFE      (15849): [15849] 26:17:05.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:35.469+0900 W/LFE      (15849): [15849] 26:17:07.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:36.830+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127536836
06-03 00:22:36.950+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127536955
06-03 00:22:36.950+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:22:36.960+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:22:36.960+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:22:36.970+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:22:36.970+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:22:36.980+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:22:36.980+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:22:36.980+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:22:37.000+0900 I/CAPI_APPFW_APPLICATION( 7780): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:22:37.000+0900 I/CAPI_APPFW_APPLICATION( 7780): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:22:37.030+0900 E/TBM     ( 7780): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:22:37.081+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7780, appid: org.example.example
06-03 00:22:37.081+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:22:37.081+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7780)
06-03 00:22:37.201+0900 I/APP_CORE( 7780): appcore-efl.c: __do_app(514) > [APP 7780] Event: RESET State: CREATED
06-03 00:22:37.201+0900 I/CAPI_APPFW_APPLICATION( 7780): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:22:37.201+0900 E/EFL     ( 7780): edje<7780> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:37.201+0900 E/EFL     ( 7780): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:37.211+0900 E/EFL     ( 7780): edje<7780> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:37.211+0900 E/EFL     ( 7780): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:37.211+0900 E/EFL     ( 7780): edje<7780> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:37.211+0900 E/EFL     ( 7780): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:37.211+0900 E/EFL     ( 7780): edje<7780> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:37.211+0900 E/EFL     ( 7780): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:37.211+0900 E/EFL     ( 7780): edje<7780> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:37.211+0900 E/EFL     ( 7780): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:37.241+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:37.241+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:37.261+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:22:37.261+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:37.271+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:37.281+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:37.291+0900 W/APP_CORE( 7780): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:22:37.291+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:22:37.401+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:22:37.401+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:22:37.401+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:22:37.401+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:22:37.401+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:22:37.401+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:22:37.411+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7780) status(3)
06-03 00:22:37.411+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7780)
06-03 00:22:37.411+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7780, appid: org.example.example, status: fg
06-03 00:22:37.421+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:22:37.431+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:22:37.431+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:22:37.431+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:22:37.431+0900 I/APP_CORE( 7780): appcore-efl.c: __do_app(514) > [APP 7780] Event: RESUME State: CREATED
06-03 00:22:37.441+0900 I/APP_CORE( 7780): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:22:37.441+0900 I/APP_CORE( 7780): appcore-efl.c: __do_app(625) > [APP 7780] Initial Launching, call the resume_cb
06-03 00:22:37.441+0900 I/CAPI_APPFW_APPLICATION( 7780): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:37.761+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7780) status(0)
06-03 00:22:37.961+0900 W/LFE      (15849): [15849] 26:17:10.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:38.122+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:22:38.122+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7780.
06-03 00:22:38.122+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3251
06-03 00:22:38.192+0900 E/EFL     ( 7780): ecore_x<7780> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127538195
06-03 00:22:38.312+0900 E/EFL     ( 7780): ecore_x<7780> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127538314
06-03 00:22:38.942+0900 I/UXT     ( 7845): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:22:40.164+0900 E/EFL     ( 7780): ecore_x<7780> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127540162
06-03 00:22:40.334+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107780657861149641696
