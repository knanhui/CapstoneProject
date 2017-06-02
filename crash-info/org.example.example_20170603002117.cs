S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7444
Date: 2017-06-03 00:21:17+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7444, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3edd000, r3   = 0xb3edd020
r4   = 0x8001b6dc, r5   = 0xbe96d2a0
r6   = 0xb27c8e5d, r7   = 0xbe96d128
r8   = 0x8001b6dc, r9   = 0xb5ebf708
r10  = 0xb84445c0, fp   = 0xbe96d27c
ip   = 0xb5faf120, sp   = 0xbe96d0e8
lr   = 0xb5f73bd9, pc   = 0xb27c8e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     41388 KB
Buffers:     15924 KB
Cached:     118612 KB
VmPeak:     110064 KB
VmSize:     108580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24192 KB
VmRSS:       24192 KB
VmData:      34512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7444 TID = 7444
7444 7447 7467 7468 

Maps Information
b12c1000 b1ac0000 rw-p [stack:7468]
b1b3c000 b1b44000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b55000 b1b56000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b66000 b1b7a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b8e000 b1b8f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b9f000 b1ba2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bb3000 b1bb4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bc4000 b1bc6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd6000 b1bd8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1be8000 b1bf8000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c08000 b1c14000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c26000 b2425000 rw-p [stack:7467]
b2756000 b275d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b276e000 b2776000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2786000 b279b000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27ad000 b27b3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c3000 b27cb000 r-xp /opt/usr/apps/org.example.example/bin/example
b2923000 b2a06000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3d000 b2a65000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a77000 b3276000 rw-p [stack:7447]
b3276000 b3278000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3288000 b3292000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a3000 b32ac000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32bd000 b32ce000 r-xp /lib/libnsl-2.20-2014.11.so
b32e1000 b32e7000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f8000 b32f9000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3321000 b3328000 r-xp /usr/lib/libminizip.so.1.0.0
b3338000 b333d000 r-xp /usr/lib/libstorage.so.0.1
b334d000 b33ac000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c2000 b33d6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e6000 b342a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343a000 b3442000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3452000 b3482000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3495000 b354e000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3562000 b35b5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c6000 b35e1000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f1000 b36b2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c5000 b36d5000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e5000 b36f2000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3703000 b370a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b371a000 b375b000 r-xp /usr/lib/libmdm.so.1.2.12
b376b000 b3773000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3782000 b3792000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b3000 b3813000 r-xp /usr/lib/libasound.so.2.0.0
b3825000 b3828000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3838000 b383b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384b000 b3850000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3860000 b3861000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3871000 b387c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3890000 b3897000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a7000 b38ad000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38bd000 b38c2000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d2000 b38ed000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38fd000 b3904000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3914000 b3917000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3928000 b3956000 r-xp /usr/lib/libidn.so.11.5.44
b3966000 b397c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398d000 b3997000 r-xp /usr/lib/libcares.so.2.1.0
b39a7000 b39b1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c1000 b39c3000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d3000 b39d4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e4000 b39e8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f9000 b3a21000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a32000 b3a5b000 r-xp /usr/lib/libturbojpeg.so
b3a7b000 b3a81000 r-xp /usr/lib/libgif.so.4.1.6
b3a91000 b3ad7000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae8000 b3b09000 r-xp /usr/lib/libexif.so.12.3.3
b3b24000 b3b39000 r-xp /usr/lib/libtts.so
b3b4a000 b3b52000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b62000 b3c28000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c48000 b3d40000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d5f000 b3e2d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e44000 b3e46000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e56000 b3e5c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6c000 b3e8f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea0000 b3ea2000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb2000 b3eb4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec5000 b3eca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee1000 b3ee3000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef3000 b3efa000 r-xp /usr/lib/libsensord-share.so
b3f0a000 b3f22000 r-xp /usr/lib/libsensor.so.1.1.0
b3f33000 b3f36000 r-xp /usr/lib/libXv.so.1.0.0
b3f46000 b3f4b000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5b000 b3f60000 r-xp /usr/lib/libappcore-common.so.1.1
b3f70000 b3f77000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f8a000 b3f8e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f9f000 b407d000 r-xp /usr/lib/libCOREGL.so.4.0
b409d000 b40a0000 r-xp /usr/lib/libuuid.so.1.3.0
b40b0000 b40c7000 r-xp /usr/lib/libblkid.so.1.1.0
b40d8000 b40da000 r-xp /usr/lib/libXau.so.6.0.0
b40ea000 b4131000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4143000 b4149000 r-xp /usr/lib/libjson-c.so.2.0.1
b415a000 b415e000 r-xp /usr/lib/libogg.so.0.7.1
b416e000 b4190000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a0000 b4284000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a0000 b42a3000 r-xp /usr/lib/libEGL.so.1.4
b42b4000 b42ba000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ca000 b42cc000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42dc000 b42e9000 r-xp /usr/lib/libGLESv2.so.2.0
b42fa000 b435c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4371000 b4389000 r-xp /usr/lib/libmount.so.1.1.0
b439b000 b43af000 r-xp /usr/lib/libxcb.so.1.1.0
b43bf000 b43c6000 r-xp /lib/libcrypt-2.20-2014.11.so
b43fe000 b4400000 r-xp /usr/lib/libiri.so
b4410000 b441b000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442c000 b4462000 r-xp /usr/lib/libpulse.so.0.16.2
b4473000 b44b6000 r-xp /usr/lib/libsndfile.so.1.0.25
b44cb000 b44e0000 r-xp /lib/libexpat.so.1.5.2
b44f2000 b45b0000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c4000 b45cc000 r-xp /usr/lib/libdrm.so.2.4.0
b45dc000 b45df000 r-xp /usr/lib/libdri2.so.0.0.0
b45ef000 b463d000 r-xp /usr/lib/libssl.so.1.0.0
b4652000 b465e000 r-xp /usr/lib/libeeze.so.1.13.0
b466f000 b4678000 r-xp /usr/lib/libethumb.so.1.13.0
b4688000 b468b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469b000 b4852000 r-xp /usr/lib/libcrypto.so.1.0.0
b563d000 b5646000 r-xp /usr/lib/libXi.so.6.1.0
b5656000 b5658000 r-xp /usr/lib/libXgesture.so.7.0.0
b5668000 b566c000 r-xp /usr/lib/libXtst.so.6.1.0
b567c000 b5682000 r-xp /usr/lib/libXrender.so.1.3.0
b5692000 b5698000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a8000 b56aa000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bb000 b56be000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ce000 b56d9000 r-xp /usr/lib/libXext.so.6.4.0
b56e9000 b56eb000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fb000 b56fd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570d000 b57ef000 r-xp /usr/lib/libX11.so.6.3.0
b5803000 b580a000 r-xp /usr/lib/libXcursor.so.1.0.2
b581a000 b5832000 r-xp /usr/lib/libudev.so.1.6.0
b5834000 b5837000 r-xp /lib/libattr.so.1.1.0
b5847000 b5867000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5868000 b586d000 r-xp /usr/lib/libffi.so.6.0.2
b587e000 b5896000 r-xp /lib/libz.so.1.2.8
b58a6000 b58a8000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b8000 b598d000 r-xp /usr/lib/libxml2.so.2.9.2
b59a2000 b5a3d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a59000 b5a5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6c000 b5a85000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a96000 b5aa7000 r-xp /lib/libresolv-2.20-2014.11.so
b5abb000 b5b35000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4a000 b5b4c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5c000 b5b63000 r-xp /usr/lib/libembryo.so.1.13.0
b5b73000 b5b7d000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b8e000 b5ba6000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb7000 b5bda000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfb000 b5c0f000 r-xp /usr/lib/libector.so.1.13.0
b5c20000 b5c38000 r-xp /usr/lib/liblua-5.1.so
b5c49000 b5ca0000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb4000 b5cdc000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ced000 b5d00000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d11000 b5d4b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5c000 b5d6a000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7a000 b5d82000 r-xp /usr/lib/libtbm.so.1.0.0
b5d92000 b5d9f000 r-xp /usr/lib/libeio.so.1.13.0
b5daf000 b5db1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc1000 b5dc6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd6000 b5ded000 r-xp /usr/lib/libefreet.so.1.13.0
b5dff000 b5e1f000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2f000 b5e4f000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e51000 b5e57000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e67000 b5e78000 r-xp /usr/lib/libemotion.so.1.13.0
b5e89000 b5e90000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea0000 b5eaf000 r-xp /usr/lib/libeo.so.1.13.0
b5ec0000 b5ed2000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee3000 b5ee8000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef8000 b5f11000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f21000 b5f3e000 r-xp /usr/lib/libeet.so.1.13.0
b5f57000 b5f9f000 r-xp /usr/lib/libeina.so.1.13.0
b5fb0000 b5fc0000 r-xp /usr/lib/libefl.so.1.13.0
b5fd1000 b60b6000 r-xp /usr/lib/libicuuc.so.51.1
b60d3000 b6213000 r-xp /usr/lib/libicui18n.so.51.1
b622a000 b6262000 r-xp /usr/lib/libecore_x.so.1.13.0
b6274000 b6277000 r-xp /lib/libcap.so.2.21
b6287000 b62b0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c1000 b62c8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62da000 b6311000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6322000 b640d000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6420000 b6499000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ab000 b64b0000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c0000 b64ca000 r-xp /usr/lib/libvconf.so.0.2.45
b64da000 b64dc000 r-xp /usr/lib/libvasum.so.0.3.1
b64ec000 b64ee000 r-xp /usr/lib/libttrace.so.1.1
b64fe000 b6501000 r-xp /usr/lib/libiniparser.so.0
b6511000 b6537000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6547000 b654c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655d000 b6574000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6585000 b65f0000 r-xp /lib/libm-2.20-2014.11.so
b6601000 b6607000 r-xp /lib/librt-2.20-2014.11.so
b6618000 b6625000 r-xp /usr/lib/libunwind.so.8.0.1
b665b000 b677f000 r-xp /lib/libc-2.20-2014.11.so
b6794000 b67ad000 r-xp /lib/libgcc_s-4.9.so.1
b67bd000 b689f000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b0000 b68da000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68eb000 b6927000 r-xp /usr/lib/libsystemd.so.0.4.0
b6929000 b69ac000 r-xp /usr/lib/libedje.so.1.13.0
b69bf000 b69dd000 r-xp /usr/lib/libecore.so.1.13.0
b69fd000 b6b84000 r-xp /usr/lib/libevas.so.1.13.0
b6bb9000 b6bcd000 r-xp /lib/libpthread-2.20-2014.11.so
b6be1000 b6e15000 r-xp /usr/lib/libelementary.so.1.13.0
b6e44000 b6e48000 r-xp /usr/lib/libsmack.so.1.0.0
b6e58000 b6e5f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6f000 b6e71000 r-xp /usr/lib/libdlog.so.0.0.0
b6e81000 b6e84000 r-xp /usr/lib/libbundle.so.0.1.22
b6e94000 b6e96000 r-xp /lib/libdl-2.20-2014.11.so
b6ea7000 b6ebf000 r-xp /usr/lib/libaul.so.0.1.0
b6ed3000 b6ed8000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee9000 b6ef6000 r-xp /usr/lib/liblptcp.so
b6f08000 b6f0c000 r-xp /usr/lib/libsys-assert.so
b6f1d000 b6f3d000 r-xp /lib/ld-2.20-2014.11.so
b6f4e000 b6f53000 r-xp /usr/bin/launchpad-loader
b81e8000 b84a1000 rw-p [heap]
be94d000 be96e000 rw-p [stack]
be94d000 be96e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7444)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb27c8e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a32175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5eab219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5ea9fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a32515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a3a725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a3ff6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a43939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb468a173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb69cac4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb69d0a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb69d0c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6ed62bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f8c909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb27c8673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f4fbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66714bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f4feb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
 ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.062+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.103+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:17.103+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:17.133+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:17.143+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:17.143+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:17.153+0900 W/APP_CORE( 7444): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:21:17.153+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:17.153+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:17.263+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:17.263+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:17.263+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:17.263+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:17.263+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:17.263+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:17.263+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7444) status(3)
06-03 00:21:17.263+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7444)
06-03 00:21:17.263+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7444, appid: org.example.example, status: fg
06-03 00:21:17.273+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:17.273+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:17.273+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:17.273+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:17.293+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(514) > [APP 7444] Event: RESUME State: CREATED
06-03 00:21:17.303+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:17.303+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(625) > [APP 7444] Initial Launching, call the resume_cb
06-03 00:21:17.303+0900 I/CAPI_APPFW_APPLICATION( 7444): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:17.613+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7444) status(0)
06-03 00:21:17.813+0900 E/EFL     ( 7444): ecore_x<7444> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127457812
06-03 00:21:17.933+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3238
06-03 00:21:17.943+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:17.943+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7444.
06-03 00:21:17.973+0900 W/LFE      (15849): [15849] 26:15:50.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:17.983+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7444 pgid = 7444
06-03 00:21:17.983+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7444)
06-03 00:21:17.983+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:18.053+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:18.053+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:18.053+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7444] terminate event is forwarded
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7444, ]
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (512) > Not registered pid(7444)
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:18.053+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:18.053+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7444
06-03 00:21:18.053+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7444
06-03 00:21:18.053+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7444
06-03 00:21:18.063+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3239
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:18.073+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:18.073+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:18.073+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:18.073+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:18.073+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:18.073+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:18.083+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:18.083+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:18.083+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7444.
06-03 00:21:18.093+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:18.093+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:18.103+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:18.114+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:18.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.114+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:18.114+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:18.114+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:18.114+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:18.264+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:18.264+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:18.654+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127458652
06-03 00:21:18.744+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127458738
06-03 00:21:18.744+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:18.744+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:18.754+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:18.764+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:18.764+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:18.774+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-03 00:21:18.774+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:18.774+0900 E/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(273) > launching failed
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7473
06-03 00:21:18.824+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7473
06-03 00:21:18.824+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7473, appid: org.example.example
06-03 00:21:18.824+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:18.834+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7473)
06-03 00:21:18.854+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:18.854+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7473.
06-03 00:21:19.004+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:19.415+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:19.435+0900 I/UXT     ( 7470): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:19.475+0900 E/TBM     ( 7473): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:19.475+0900 I/MALI    ( 7473): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=7473   open drm_fd=84 
06-03 00:21:19.805+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESET State: CREATED
06-03 00:21:19.805+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.815+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.815+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.845+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:19.845+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:19.855+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:19.865+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:19.865+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:19.875+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:19.905+0900 W/APP_CORE( 7473): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00003
06-03 00:21:19.905+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:19.915+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:19.915+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:19.915+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:19.915+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:19.915+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:19.915+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(3)
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:19.925+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7473)
06-03 00:21:19.925+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: fg
06-03 00:21:19.935+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:19.935+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:19.935+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:19.935+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:19.985+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESUME State: CREATED
06-03 00:21:20.005+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:20.005+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(625) > [APP 7473] Initial Launching, call the resume_cb
06-03 00:21:20.005+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:20.276+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(0)
06-03 00:21:20.476+0900 W/LFE      (15849): [15849] 26:15:52.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:20.996+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:21:21.046+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073156578611496416863
06-03 00:21:22.668+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=127462668
06-03 00:21:22.838+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:21:22.838+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:21:22.838+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=127462840
06-03 00:21:22.838+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:21:22.838+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:21:22.838+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:21:22.838+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:21:22.858+0900 W/APP_CORE( 7473): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 00:21:22.858+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: PAUSE State: RUNNING
06-03 00:21:22.858+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-03 00:21:22.868+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 00:21:22.868+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-03 00:21:22.868+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-03 00:21:22.868+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:21:22.868+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:21:22.878+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:21:22.878+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:21:22.888+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7520
06-03 00:21:22.888+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:22.898+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:21:22.938+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7520
06-03 00:21:22.938+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7520, appid: com.samsung.weather-m-agent
06-03 00:21:22.938+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7520)
06-03 00:21:22.948+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:21:22.948+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7520.
06-03 00:21:22.958+0900 W/LFE      (15849): [15849] 26:15:55.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:23.078+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:21:23.078+0900 E/weather-common( 7520): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:21:23.088+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:21:23.088+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:21:23.088+0900 I/MESSAGE_PORT( 7520): message-port.c: __initialize(872) > initialize
06-03 00:21:23.098+0900 I/MESSAGE_PORT( 7520): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:21:23.239+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:21:23.249+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:21:23.249+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:21:23.249+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:21:23.249+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:21:23.259+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: PAUSE State: PAUSED
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(3)
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:23.269+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(845)
06-03 00:21:23.269+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: fg
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(4)
06-03 00:21:23.269+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.example(7473)
06-03 00:21:23.269+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: bg
06-03 00:21:23.279+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(0)
06-03 00:21:23.299+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.299+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.299+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.309+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:21:23.309+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:21:23.319+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.339+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:21:23.339+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:21:23.339+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.349+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:21:23.349+0900 E/weather-agent( 7520): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:21:23.349+0900 E/weather-agent( 7520): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:21:23.349+0900 I/MESSAGE_PORT( 7520): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:21:23.349+0900 I/MESSAGE_PORT( 7520): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:21:23.359+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:23.359+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:23.369+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:23.379+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:21:23.379+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:23.379+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 7473): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 117
06-03 00:21:23.379+0900 E/APP_CORE( 7473): appcore-efl.c: _capture_and_make_file(1619) > win[8a00003] widget[720] height[1280]
06-03 00:21:23.379+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 00:21:23.379+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.379+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:21:23.379+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:23.389+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.439+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:23.439+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:21:23.489+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:23.499+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:23.499+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:21:23.509+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:21:23.509+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-03 00:21:23.519+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-03 00:21:23.519+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-03 00:21:23.519+0900 W/APP_CORE(  845): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-03 00:21:23.539+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-03 00:21:24.350+0900 E/weather-agent( 7520): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:21:24.350+0900 I/CAPI_APPFW_APPLICATION( 7520): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:21:24.350+0900 E/weather-agent( 7520): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:21:24.350+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:21:24.350+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:21:24.470+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:21:24.480+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7520
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7520] terminate event is forwarded
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7520, ]
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (512) > Not registered pid(7520)
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:21:24.480+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:24.480+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7520
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7520.
06-03 00:21:24.920+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:21:25.471+0900 W/LFE      (15849): [15849] 26:15:57.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:27.873+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: MEM_FLUSH State: PAUSED
06-03 00:21:27.973+0900 W/LFE      (15849): [15849] 26:16:00.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:28.283+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073066578611496416868
06-03 00:21:29.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:21:30.476+0900 W/LFE      (15849): [15849] 26:16:02.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:32.968+0900 W/LFE      (15849): [15849] 26:16:05.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:35.470+0900 W/LFE      (15849): [15849] 26:16:07.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:35.741+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073716578611496416871
06-03 00:21:37.973+0900 W/LFE      (15849): [15849] 26:16:10.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:40.475+0900 W/LFE      (15849): [15849] 26:16:12.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:42.878+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073926578611496416873
06-03 00:21:42.958+0900 W/LFE      (15849): [15849] 26:16:15.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:45.480+0900 W/LFE      (15849): [15849] 26:16:17.558[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:47.983+0900 W/LFE      (15849): [15849] 26:16:20.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:49.995+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074456578611496416875
06-03 00:21:50.465+0900 W/LFE      (15849): [15849] 26:16:22.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:52.957+0900 W/LFE      (15849): [15849] 26:16:25.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:55.460+0900 W/LFE      (15849): [15849] 26:16:27.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:57.041+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107444657861149641687
