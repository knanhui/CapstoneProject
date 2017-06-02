S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 8140
Date: 2017-06-03 01:04:16+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8140, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3ed0000, r3   = 0xb3ed0020
r4   = 0x8001b6dc, r5   = 0xbecc02a0
r6   = 0xb27bbe5d, r7   = 0xbecc0128
r8   = 0x8001b6dc, r9   = 0xb5eb2708
r10  = 0xb8c22d98, fp   = 0xbecc027c
ip   = 0xb5fa2120, sp   = 0xbecc00e8
lr   = 0xb5f66bd9, pc   = 0xb27bbe86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     29864 KB
Buffers:     13760 KB
Cached:     109308 KB
VmPeak:     111652 KB
VmSize:     105668 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29004 KB
VmRSS:       26928 KB
VmData:      27952 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8140 TID = 8140
8140 8141 8510 

Maps Information
b1b2f000 b1b37000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b48000 b1b49000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b59000 b1b6d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b81000 b1b82000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b92000 b1b95000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1ba6000 b1ba7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bb7000 b1bb9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bc9000 b1bcb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bdb000 b1beb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bfb000 b1c07000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c19000 b2418000 rw-p [stack:8510]
b2749000 b2750000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2761000 b2769000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2779000 b278e000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27a0000 b27a6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b6000 b27be000 r-xp /opt/usr/apps/org.example.example/bin/example
b2916000 b29f9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a30000 b2a58000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a6a000 b3269000 rw-p [stack:8141]
b3269000 b326b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b327b000 b3285000 r-xp /lib/libnss_files-2.20-2014.11.so
b3296000 b329f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32b0000 b32c1000 r-xp /lib/libnsl-2.20-2014.11.so
b32d4000 b32da000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32eb000 b32ec000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3314000 b331b000 r-xp /usr/lib/libminizip.so.1.0.0
b332b000 b3330000 r-xp /usr/lib/libstorage.so.0.1
b3340000 b339f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33b5000 b33c9000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33d9000 b341d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b342d000 b3435000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3445000 b3475000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3488000 b3541000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3555000 b35a8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35b9000 b35d4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35e4000 b36a5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36b8000 b36c8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36d8000 b36e5000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36f6000 b36fd000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b370d000 b374e000 r-xp /usr/lib/libmdm.so.1.2.12
b375e000 b3766000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3775000 b3785000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37a6000 b3806000 r-xp /usr/lib/libasound.so.2.0.0
b3818000 b381b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b382b000 b382e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b383e000 b3843000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3853000 b3854000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3864000 b386f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3883000 b388a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b389a000 b38a0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38b0000 b38b5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38c5000 b38e0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38f0000 b38f7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3907000 b390a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b391b000 b3949000 r-xp /usr/lib/libidn.so.11.5.44
b3959000 b396f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3980000 b398a000 r-xp /usr/lib/libcares.so.2.1.0
b399a000 b39a4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39b4000 b39b6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39c6000 b39c7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39d7000 b39db000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ec000 b3a14000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a25000 b3a4e000 r-xp /usr/lib/libturbojpeg.so
b3a6e000 b3a74000 r-xp /usr/lib/libgif.so.4.1.6
b3a84000 b3aca000 r-xp /usr/lib/libcurl.so.4.3.0
b3adb000 b3afc000 r-xp /usr/lib/libexif.so.12.3.3
b3b17000 b3b2c000 r-xp /usr/lib/libtts.so
b3b3d000 b3b45000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b55000 b3c1b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c3b000 b3d33000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d52000 b3e20000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e37000 b3e39000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e49000 b3e4f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e5f000 b3e82000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e93000 b3e95000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ea5000 b3ea7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eb8000 b3ebd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ed4000 b3ed6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ee6000 b3eed000 r-xp /usr/lib/libsensord-share.so
b3efd000 b3f15000 r-xp /usr/lib/libsensor.so.1.1.0
b3f26000 b3f29000 r-xp /usr/lib/libXv.so.1.0.0
b3f39000 b3f3e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f4e000 b3f53000 r-xp /usr/lib/libappcore-common.so.1.1
b3f63000 b3f6a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f7d000 b3f81000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f92000 b4070000 r-xp /usr/lib/libCOREGL.so.4.0
b4090000 b4093000 r-xp /usr/lib/libuuid.so.1.3.0
b40a3000 b40ba000 r-xp /usr/lib/libblkid.so.1.1.0
b40cb000 b40cd000 r-xp /usr/lib/libXau.so.6.0.0
b40dd000 b4124000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4136000 b413c000 r-xp /usr/lib/libjson-c.so.2.0.1
b414d000 b4151000 r-xp /usr/lib/libogg.so.0.7.1
b4161000 b4183000 r-xp /usr/lib/libvorbis.so.0.4.3
b4193000 b4277000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4293000 b4296000 r-xp /usr/lib/libEGL.so.1.4
b42a7000 b42ad000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42bd000 b42bf000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42cf000 b42dc000 r-xp /usr/lib/libGLESv2.so.2.0
b42ed000 b434f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4364000 b437c000 r-xp /usr/lib/libmount.so.1.1.0
b438e000 b43a2000 r-xp /usr/lib/libxcb.so.1.1.0
b43b2000 b43b9000 r-xp /lib/libcrypt-2.20-2014.11.so
b43f1000 b43f3000 r-xp /usr/lib/libiri.so
b4403000 b440e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b441f000 b4455000 r-xp /usr/lib/libpulse.so.0.16.2
b4466000 b44a9000 r-xp /usr/lib/libsndfile.so.1.0.25
b44be000 b44d3000 r-xp /lib/libexpat.so.1.5.2
b44e5000 b45a3000 r-xp /usr/lib/libcairo.so.2.11200.14
b45b7000 b45bf000 r-xp /usr/lib/libdrm.so.2.4.0
b45cf000 b45d2000 r-xp /usr/lib/libdri2.so.0.0.0
b45e2000 b4630000 r-xp /usr/lib/libssl.so.1.0.0
b4645000 b4651000 r-xp /usr/lib/libeeze.so.1.13.0
b4662000 b466b000 r-xp /usr/lib/libethumb.so.1.13.0
b467b000 b467e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b468e000 b4845000 r-xp /usr/lib/libcrypto.so.1.0.0
b5630000 b5639000 r-xp /usr/lib/libXi.so.6.1.0
b5649000 b564b000 r-xp /usr/lib/libXgesture.so.7.0.0
b565b000 b565f000 r-xp /usr/lib/libXtst.so.6.1.0
b566f000 b5675000 r-xp /usr/lib/libXrender.so.1.3.0
b5685000 b568b000 r-xp /usr/lib/libXrandr.so.2.2.0
b569b000 b569d000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ae000 b56b1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c1000 b56cc000 r-xp /usr/lib/libXext.so.6.4.0
b56dc000 b56de000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ee000 b56f0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5700000 b57e2000 r-xp /usr/lib/libX11.so.6.3.0
b57f6000 b57fd000 r-xp /usr/lib/libXcursor.so.1.0.2
b580d000 b5825000 r-xp /usr/lib/libudev.so.1.6.0
b5827000 b582a000 r-xp /lib/libattr.so.1.1.0
b583a000 b585a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b585b000 b5860000 r-xp /usr/lib/libffi.so.6.0.2
b5871000 b5889000 r-xp /lib/libz.so.1.2.8
b5899000 b589b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ab000 b5980000 r-xp /usr/lib/libxml2.so.2.9.2
b5995000 b5a30000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a4c000 b5a4f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a5f000 b5a78000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a89000 b5a9a000 r-xp /lib/libresolv-2.20-2014.11.so
b5aae000 b5b28000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b3d000 b5b3f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b4f000 b5b56000 r-xp /usr/lib/libembryo.so.1.13.0
b5b66000 b5b70000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b81000 b5b99000 r-xp /usr/lib/libpng12.so.0.50.0
b5baa000 b5bcd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bee000 b5c02000 r-xp /usr/lib/libector.so.1.13.0
b5c13000 b5c2b000 r-xp /usr/lib/liblua-5.1.so
b5c3c000 b5c93000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca7000 b5ccf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce0000 b5cf3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d04000 b5d3e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d4f000 b5d5d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d6d000 b5d75000 r-xp /usr/lib/libtbm.so.1.0.0
b5d85000 b5d92000 r-xp /usr/lib/libeio.so.1.13.0
b5da2000 b5da4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db4000 b5db9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dc9000 b5de0000 r-xp /usr/lib/libefreet.so.1.13.0
b5df2000 b5e12000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e22000 b5e42000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e44000 b5e4a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e5a000 b5e6b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e7c000 b5e83000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e93000 b5ea2000 r-xp /usr/lib/libeo.so.1.13.0
b5eb3000 b5ec5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed6000 b5edb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eeb000 b5f04000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f14000 b5f31000 r-xp /usr/lib/libeet.so.1.13.0
b5f4a000 b5f92000 r-xp /usr/lib/libeina.so.1.13.0
b5fa3000 b5fb3000 r-xp /usr/lib/libefl.so.1.13.0
b5fc4000 b60a9000 r-xp /usr/lib/libicuuc.so.51.1
b60c6000 b6206000 r-xp /usr/lib/libicui18n.so.51.1
b621d000 b6255000 r-xp /usr/lib/libecore_x.so.1.13.0
b6267000 b626a000 r-xp /lib/libcap.so.2.21
b627a000 b62a3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b4000 b62bb000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62cd000 b6304000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6315000 b6400000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6413000 b648c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b649e000 b64a3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64b3000 b64bd000 r-xp /usr/lib/libvconf.so.0.2.45
b64cd000 b64cf000 r-xp /usr/lib/libvasum.so.0.3.1
b64df000 b64e1000 r-xp /usr/lib/libttrace.so.1.1
b64f1000 b64f4000 r-xp /usr/lib/libiniparser.so.0
b6504000 b652a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b653a000 b653f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6550000 b6567000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6578000 b65e3000 r-xp /lib/libm-2.20-2014.11.so
b65f4000 b65fa000 r-xp /lib/librt-2.20-2014.11.so
b660b000 b6618000 r-xp /usr/lib/libunwind.so.8.0.1
b664e000 b6772000 r-xp /lib/libc-2.20-2014.11.so
b6787000 b67a0000 r-xp /lib/libgcc_s-4.9.so.1
b67b0000 b6892000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68a3000 b68cd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68de000 b691a000 r-xp /usr/lib/libsystemd.so.0.4.0
b691c000 b699f000 r-xp /usr/lib/libedje.so.1.13.0
b69b2000 b69d0000 r-xp /usr/lib/libecore.so.1.13.0
b69f0000 b6b77000 r-xp /usr/lib/libevas.so.1.13.0
b6bac000 b6bc0000 r-xp /lib/libpthread-2.20-2014.11.so
b6bd4000 b6e08000 r-xp /usr/lib/libelementary.so.1.13.0
b6e37000 b6e3b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e4b000 b6e52000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e62000 b6e64000 r-xp /usr/lib/libdlog.so.0.0.0
b6e74000 b6e77000 r-xp /usr/lib/libbundle.so.0.1.22
b6e87000 b6e89000 r-xp /lib/libdl-2.20-2014.11.so
b6e9a000 b6eb2000 r-xp /usr/lib/libaul.so.0.1.0
b6ec6000 b6ecb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6edc000 b6ee9000 r-xp /usr/lib/liblptcp.so
b6efb000 b6eff000 r-xp /usr/lib/libsys-assert.so
b6f10000 b6f30000 r-xp /lib/ld-2.20-2014.11.so
b6f41000 b6f46000 r-xp /usr/bin/launchpad-loader
b89b8000 b8c71000 rw-p [heap]
beca0000 becc1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8140)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb27bbe86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a25175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5e9e219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e9cfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a25515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a2d725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a32f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a36939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb467d173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb69bdc4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb69c3a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb69c3c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6ec92bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f7f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb27bb673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f42bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66644bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f42eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
   ( 8140): edje<8140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:00:52.430+0900 E/EFL     ( 8140): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:00:52.430+0900 E/EFL     ( 8140): edje<8140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:00:52.430+0900 E/EFL     ( 8140): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:00:52.430+0900 E/EFL     ( 8140): edje<8140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:00:52.430+0900 E/EFL     ( 8140): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:00:52.440+0900 E/EFL     ( 8140): edje<8140> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:00:52.440+0900 E/EFL     ( 8140): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:00:52.520+0900 W/APP_CORE( 8140): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:a400002
06-03 01:00:52.520+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:00:52.650+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8140) status(4)
06-03 01:00:52.680+0900 I/APP_CORE( 8140): appcore-efl.c: __do_app(514) > [APP 8140] Event: PAUSE State: CREATED
06-03 01:00:52.700+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 8140): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 14
06-03 01:00:52.700+0900 E/APP_CORE( 8140): appcore-efl.c: _capture_and_make_file(1619) > win[a400002] widget[720] height[1280]
06-03 01:00:52.700+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:00:52.980+0900 W/LFE      (15849): [15849] 26:55:25.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:00:52.990+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8140) status(0)
06-03 01:00:53.231+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:00:53.231+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 01:00:53.271+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3295
06-03 01:00:53.281+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:00:53.281+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 8140.
06-03 01:00:54.122+0900 I/UXT     ( 8511): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:00:55.463+0900 W/LFE      (15849): [15849] 26:55:27.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:00:57.235+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.example(8140)
06-03 01:00:57.235+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8140, appid: org.example.example, status: bg
06-03 01:00:57.965+0900 W/LFE      (15849): [15849] 26:55:30.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:00.468+0900 W/LFE      (15849): [15849] 26:55:32.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:02.960+0900 W/LFE      (15849): [15849] 26:55:35.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:05.473+0900 W/LFE      (15849): [15849] 26:55:37.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:07.975+0900 W/LFE      (15849): [15849] 26:55:40.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:10.478+0900 W/LFE      (15849): [15849] 26:55:42.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:12.970+0900 W/LFE      (15849): [15849] 26:55:45.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:15.472+0900 W/LFE      (15849): [15849] 26:55:47.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:16.924+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 01:01:17.975+0900 W/LFE      (15849): [15849] 26:55:50.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:20.477+0900 W/LFE      (15849): [15849] 26:55:52.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:22.970+0900 W/LFE      (15849): [15849] 26:55:55.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:25.472+0900 W/LFE      (15849): [15849] 26:55:57.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:27.975+0900 W/LFE      (15849): [15849] 26:56:00.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:30.477+0900 W/LFE      (15849): [15849] 26:56:02.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:32.979+0900 W/LFE      (15849): [15849] 26:56:05.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:35.462+0900 W/LFE      (15849): [15849] 26:56:07.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:37.964+0900 W/LFE      (15849): [15849] 26:56:10.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:40.457+0900 W/LFE      (15849): [15849] 26:56:12.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:42.959+0900 W/LFE      (15849): [15849] 26:56:15.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:45.472+0900 W/LFE      (15849): [15849] 26:56:17.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:47.974+0900 W/LFE      (15849): [15849] 26:56:20.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:50.467+0900 W/LFE      (15849): [15849] 26:56:22.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:52.979+0900 W/LFE      (15849): [15849] 26:56:25.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:55.471+0900 W/LFE      (15849): [15849] 26:56:27.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:01:57.964+0900 W/LFE      (15849): [15849] 26:56:30.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:00.466+0900 W/LFE      (15849): [15849] 26:56:32.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:02.959+0900 W/LFE      (15849): [15849] 26:56:35.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:05.461+0900 W/LFE      (15849): [15849] 26:56:37.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:07.974+0900 W/LFE      (15849): [15849] 26:56:40.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:10.476+0900 W/LFE      (15849): [15849] 26:56:42.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:12.968+0900 W/LFE      (15849): [15849] 26:56:45.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:15.471+0900 W/LFE      (15849): [15849] 26:56:47.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:16.982+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 01:02:17.973+0900 W/LFE      (15849): [15849] 26:56:50.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:20.476+0900 W/LFE      (15849): [15849] 26:56:52.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:22.968+0900 W/LFE      (15849): [15849] 26:56:55.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:25.471+0900 W/LFE      (15849): [15849] 26:56:57.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:27.983+0900 W/LFE      (15849): [15849] 26:57:00.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:30.486+0900 W/LFE      (15849): [15849] 26:57:02.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:32.968+0900 W/LFE      (15849): [15849] 26:57:05.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:35.460+0900 W/LFE      (15849): [15849] 26:57:07.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:37.963+0900 W/LFE      (15849): [15849] 26:57:10.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:40.465+0900 W/LFE      (15849): [15849] 26:57:12.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:42.978+0900 W/LFE      (15849): [15849] 26:57:15.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:45.470+0900 W/LFE      (15849): [15849] 26:57:17.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:47.973+0900 W/LFE      (15849): [15849] 26:57:20.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:50.485+0900 W/LFE      (15849): [15849] 26:57:22.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:52.957+0900 W/LFE      (15849): [15849] 26:57:25.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:55.460+0900 W/LFE      (15849): [15849] 26:57:27.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:02:57.962+0900 W/LFE      (15849): [15849] 26:57:30.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:00.465+0900 W/LFE      (15849): [15849] 26:57:32.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:02.957+0900 W/LFE      (15849): [15849] 26:57:35.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:05.470+0900 W/LFE      (15849): [15849] 26:57:37.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:07.972+0900 W/LFE      (15849): [15849] 26:57:40.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:10.475+0900 W/LFE      (15849): [15849] 26:57:42.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:12.967+0900 W/LFE      (15849): [15849] 26:57:45.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:15.469+0900 W/LFE      (15849): [15849] 26:57:47.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:17.041+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 01:03:17.972+0900 W/LFE      (15849): [15849] 26:57:50.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:20.474+0900 W/LFE      (15849): [15849] 26:57:52.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:22.977+0900 W/LFE      (15849): [15849] 26:57:55.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:25.459+0900 W/LFE      (15849): [15849] 26:57:57.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:27.972+0900 W/LFE      (15849): [15849] 26:58:00.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:30.474+0900 W/LFE      (15849): [15849] 26:58:02.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:32.967+0900 W/LFE      (15849): [15849] 26:58:05.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:35.479+0900 W/LFE      (15849): [15849] 26:58:07.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:37.971+0900 W/LFE      (15849): [15849] 26:58:10.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:40.474+0900 W/LFE      (15849): [15849] 26:58:12.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:42.986+0900 W/LFE      (15849): [15849] 26:58:15.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:44.248+0900 W/LOCKSCREEN(  845): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 89
06-03 01:03:44.248+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
06-03 01:03:44.248+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:200
06-03 01:03:44.248+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
06-03 01:03:44.258+0900 E/INDICATOR(  646): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
06-03 01:03:45.459+0900 W/LFE      (15849): [15849] 26:58:17.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:47.961+0900 W/LFE      (15849): [15849] 26:58:20.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:50.474+0900 W/LFE      (15849): [15849] 26:58:22.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:52.976+0900 W/LFE      (15849): [15849] 26:58:25.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:55.468+0900 W/LFE      (15849): [15849] 26:58:27.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:03:57.981+0900 W/LFE      (15849): [15849] 26:58:30.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:00.463+0900 W/LFE      (15849): [15849] 26:58:32.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:02.966+0900 W/LFE      (15849): [15849] 26:58:35.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:05.458+0900 W/LFE      (15849): [15849] 26:58:37.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:07.971+0900 W/LFE      (15849): [15849] 26:58:40.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:10.473+0900 W/LFE      (15849): [15849] 26:58:42.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:12.976+0900 W/LFE      (15849): [15849] 26:58:45.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:15.478+0900 W/LFE      (15849): [15849] 26:58:47.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 01:04:15.538+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 01:04:15.548+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:15.548+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:04:15.548+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 01:04:15.558+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:04
06-03 01:04:15.558+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:04"
06-03 01:04:15.558+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:04"
06-03 01:04:15.558+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:04:15.558+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145421069 Time: <font_size=31> </font_size> <font_size=31> 오전 1:04</font_size></font>"
06-03 01:04:15.558+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(8) / batt_Full:(0) / battery_charging(1)"
06-03 01:04:15.558+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 01:04:15.558+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:04:15.558+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:04:15.558+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:04:15.558+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:04:15.558+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:04:15.788+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 01:04:15.788+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 01:04:15.788+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 01:04:15.788+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 01:04:15.788+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:15.788+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 01:04:15.788+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 01:04:15.788+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:04:15.798+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 01:04:15.798+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:04:15.798+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 01:04:15.798+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 01:04:15.808+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:04:15.808+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 8535
06-03 01:04:15.858+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 8535
06-03 01:04:15.858+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8535, appid: com.samsung.weather-m-agent
06-03 01:04:15.878+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8535)
06-03 01:04:15.908+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 01:04:15.908+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 8535.
06-03 01:04:16.089+0900 E/weather-agent( 8535): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 01:04:16.089+0900 E/weather-common( 8535): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 01:04:16.099+0900 E/weather-agent( 8535): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 01:04:16.099+0900 E/weather-agent( 8535): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 01:04:16.099+0900 E/weather-common( 8535): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 01:04:16.099+0900 E/weather-common( 8535): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 01:04:16.099+0900 E/weather-common( 8535): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 01:04:16.099+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 01:04:16.099+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 01:04:16.099+0900 I/MESSAGE_PORT( 8535): message-port.c: __initialize(872) > initialize
06-03 01:04:16.109+0900 I/MESSAGE_PORT( 8535): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:04:16.149+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130036153
06-03 01:04:16.149+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 01:04:16.149+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:16.159+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:04:16.159+0900 E/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 01:04:16.159+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:16.159+0900 E/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 01:04:16.159+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:16.159+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 01:04:16.159+0900 I/MESSAGE_PORT( 8535): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:16.169+0900 E/MESSAGE_PORT( 8535): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 01:04:16.169+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 01:04:16.169+0900 E/weather-common( 8535): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 01:04:16.169+0900 E/weather-agent( 8535): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 01:04:16.169+0900 E/weather-agent( 8535): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 01:04:16.169+0900 I/MESSAGE_PORT( 8535): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:04:16.169+0900 I/MESSAGE_PORT( 8535): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:04:16.179+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:16.199+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:04:16.209+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:04:16.209+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:16.219+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:16.229+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 01:04:16.229+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:16.229+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 01:04:16.229+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 01:04:16.249+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=130036250
06-03 01:04:16.249+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 01:04:16.249+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 01:04:16.249+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:04:16.259+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 01:04:16.259+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:04:16.259+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:04:16.259+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.259+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.259+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.279+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:04:16.279+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:04:16.279+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:04:16.289+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:04:16.289+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:04:16.289+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.289+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.289+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.299+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:04:16.299+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:16.299+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:04:16.299+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:04:16.299+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:04:16.299+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:04:16.359+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:04:16.369+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 01:04:16.599+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:04:16.599+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:04:16.599+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:04:16.599+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:04:16.619+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:16.629+0900 I/APP_CORE( 8140): appcore-efl.c: __do_app(514) > [APP 8140] Event: RESUME State: CREATED
06-03 01:04:16.629+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:16.629+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 01:04:16.629+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 01:04:16.629+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 01:04:16.639+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8140) status(3)
06-03 01:04:16.639+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:16.639+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:16.639+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(8140)
06-03 01:04:16.639+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8140, appid: org.example.example, status: fg
06-03 01:04:16.639+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 01:04:16.649+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 01:04:16.649+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 01:04:16.649+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 01:04:16.649+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 01:04:16.649+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:16.649+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:16.649+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:04:16.649+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 01:04:16.649+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 01:04:16.649+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:04:16.649+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:04:16.669+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:04:16.679+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:04:16.679+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:16.679+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:16.689+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:16.689+0900 I/APP_CORE( 8140): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:04:16.689+0900 I/APP_CORE( 8140): appcore-efl.c: __do_app(625) > [APP 8140] Initial Launching, call the resume_cb
06-03 01:04:16.689+0900 I/CAPI_APPFW_APPLICATION( 8140): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:16.749+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 01:04:16.749+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:04:16.749+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:16.749+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:04:16.749+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:04:16.749+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 01:04:16.839+0900 E/EFL     ( 8140): ecore_x<8140> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130036816
06-03 01:04:16.999+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:16.999+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8140 pgid = 8140
06-03 01:04:16.999+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(8140)
06-03 01:04:17.020+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:04:17.020+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:17.020+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:17.020+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:04:17.020+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:04:17.040+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.example/shared/res/1.jpg], Loading state:[1]
06-03 01:04:17.060+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:04:17.060+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:04:17.060+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:04:17.070+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[8140] terminate event is forwarded
06-03 01:04:17.070+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:04:17.070+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 8140, ]
06-03 01:04:17.070+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:04:17.070+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:04:17.070+0900 I/Tizen::App( 1210): (512) > Not registered pid(8140)
06-03 01:04:17.070+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:04:17.070+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:17.070+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8140
06-03 01:04:17.070+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8140
06-03 01:04:17.070+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8140
06-03 01:04:17.070+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3300
06-03 01:04:17.090+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:04:17.090+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:04:17.100+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 01:04:17.100+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:17.100+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 8140.
06-03 01:04:17.110+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:04:17.110+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:17.110+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:04:17.120+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:17.130+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:17.140+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:04:17.140+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:17.170+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:17.170+0900 E/weather-agent( 8535): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 01:04:17.170+0900 I/CAPI_APPFW_APPLICATION( 8535): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 01:04:17.180+0900 W/CRASH_MANAGER( 8545): worker.c: worker_job(1199) > 1108140657861149641945
