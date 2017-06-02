S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 6622
Date: 2017-06-03 00:12:58+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6622, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3ed0000, r3   = 0xb3ed0020
r4   = 0x8001b6dc, r5   = 0xbe9642a0
r6   = 0xb27bbe5d, r7   = 0xbe964128
r8   = 0x8001b6dc, r9   = 0xb5eb2708
r10  = 0xb8ad2020, fp   = 0xbe96427c
ip   = 0xb5fa2120, sp   = 0xbe9640e8
lr   = 0xb5f66bd9, pc   = 0xb27bbe86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     52028 KB
Buffers:     13904 KB
Cached:     112532 KB
VmPeak:     110064 KB
VmSize:     108580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24128 KB
VmRSS:       24128 KB
VmData:      34512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6622 TID = 6622
6622 6623 6657 6660 

Maps Information
b12b4000 b1ab3000 rw-p [stack:6660]
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
b1c19000 b2418000 rw-p [stack:6657]
b2749000 b2750000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2761000 b2769000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2779000 b278e000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27a0000 b27a6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b6000 b27be000 r-xp /opt/usr/apps/org.example.example/bin/example
b2916000 b29f9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a30000 b2a58000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a6a000 b3269000 rw-p [stack:6623]
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
b8867000 b8b20000 rw-p [heap]
be944000 be965000 rw-p [stack]
be944000 be965000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6622)
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
4f54160 
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:12:49.327+0900 E/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:12:49.327+0900 E/weather-agent( 6627): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:12:49.327+0900 E/weather-agent( 6627): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:12:49.337+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:49.357+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.407+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:12:49.407+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:12:49.427+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:12:49.427+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:49.427+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:12:49.457+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:49.487+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:12:49.497+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:12:49.497+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:12:49.497+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.517+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:12:49.527+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.527+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:12:49.527+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:12:49.527+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:12:49.527+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:12:49.587+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:12:49.587+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:49.758+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126949757
06-03 00:12:49.918+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126949921
06-03 00:12:49.918+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:12:49.918+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:12:50.248+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:12:50.258+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:12:50.258+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:12:50.268+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:12:50.278+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:12:50.278+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:12:50.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:50.288+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:12:50.288+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:12:50.288+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6053) status(3)
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:50.298+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6053)
06-03 00:12:50.298+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6053, appid: org.example.example, status: fg
06-03 00:12:50.298+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(514) > [APP 6053] Event: RESUME State: CREATED
06-03 00:12:50.318+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:12:50.318+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(625) > [APP 6053] Initial Launching, call the resume_cb
06-03 00:12:50.318+0900 I/CAPI_APPFW_APPLICATION( 6053): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:50.328+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:12:50.338+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:12:50.338+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:50.338+0900 E/weather-agent( 6627): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:12:50.338+0900 I/CAPI_APPFW_APPLICATION( 6627): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:12:50.338+0900 E/weather-agent( 6627): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:12:50.338+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:12:50.338+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:12:50.348+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:50.378+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:12:50.378+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:12:50.378+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:12:50.388+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:12:50.458+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:12:50.468+0900 W/LFE      (15849): [15849] 26:07:22.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:50.528+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[6627] terminate event is forwarded
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6627, ]
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (512) > Not registered pid(6627)
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:12:50.538+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:50.538+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6627
06-03 00:12:50.538+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6627
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6627.
06-03 00:12:51.499+0900 E/EFL     ( 6053): ecore_x<6053> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126951507
06-03 00:12:51.719+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6053 pgid = 6053
06-03 00:12:51.719+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6053)
06-03 00:12:51.719+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:51.780+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:12:51.780+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:12:51.780+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:12:51.780+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/usr/apps/com.samsung.homescreen/res/images/HD/calendar/calendar_03.png], Loading state:[1]
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6053] terminate event is forwarded
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6053, ]
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (512) > Not registered pid(6053)
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:12:51.790+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:51.790+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6053
06-03 00:12:51.790+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6053
06-03 00:12:51.790+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6053
06-03 00:12:51.790+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3158
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:51.810+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:12:51.810+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:12:51.820+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:12:51.830+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:51.830+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6053.
06-03 00:12:51.840+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:51.840+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:12:51.840+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:51.840+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:12:51.860+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:51.870+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:12:51.870+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:51.890+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:51.930+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 11060536578611496416371
06-03 00:12:52.971+0900 W/LFE      (15849): [15849] 26:07:25.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:53.822+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=126953825
06-03 00:12:53.822+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=126953825
06-03 00:12:53.822+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-03 00:12:53.822+0900 W/STARTER (  793): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-03 00:12:53.822+0900 W/STARTER (  793): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-03 00:12:53.982+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=126953987
06-03 00:12:53.982+0900 W/STARTER (  793): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-03 00:12:53.982+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=126953987
06-03 00:12:53.982+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-03 00:12:53.992+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-03 00:12:53.992+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-03 00:12:53.992+0900 E/STARTER (  793): )
06-03 00:12:53.992+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-03 00:12:53.992+0900 I/SYSPOPUP(  858): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-03 00:12:53.992+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:12:53.992+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:12:54.192+0900 W/STARTER (  793): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
06-03 00:12:54.192+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-03 00:12:54.192+0900 E/STARTER (  793): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-03 00:12:54.192+0900 E/STARTER (  793): )
06-03 00:12:54.192+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 00:12:54.192+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 860
06-03 00:12:54.202+0900 W/AUL     (  793): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
06-03 00:12:54.202+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:12:54.212+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-03 00:12:54.212+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 00:12:54.212+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 793
06-03 00:12:54.212+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 00:12:54.222+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 860, appid: com.samsung.homescreen
06-03 00:12:54.222+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 860
06-03 00:12:54.222+0900 W/AUL_AMD (  610): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
06-03 00:12:54.222+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESET State: RUNNING
06-03 00:12:54.222+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:12:54.222+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(81) , send fd(80), pid(860), cmd(0)
06-03 00:12:54.222+0900 W/AUL     (  793): launch.c: app_request_to_launchpad(425) > request cmd(0) result(860)
06-03 00:12:54.222+0900 E/STARTER (  793): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
06-03 00:12:54.222+0900 W/CAPI_APPFW_APP_CONTROL(  860): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-03 00:12:54.232+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-03 00:12:54.232+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(566) > [APP 860] App already running, raise the window
06-03 00:12:55.223+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:55.223+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 00:12:55.233+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126955231
06-03 00:12:55.283+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:12:55.323+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126955318
06-03 00:12:55.333+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:12:55.333+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:12:55.333+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: fg
06-03 00:12:55.333+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:55.343+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:55.343+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:12:55.483+0900 W/LFE      (15849): [15849] 26:07:27.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:55.583+0900 W/cluster-view(  860): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
06-03 00:12:55.743+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126955738
06-03 00:12:55.833+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126955837
06-03 00:12:56.094+0900 W/cluster-view(  860): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
06-03 00:12:56.164+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:12:56.164+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:12:56.164+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:12:56.164+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:12:56.354+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.354+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.374+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.374+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.394+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.394+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.404+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.414+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.424+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.424+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.444+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.444+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.464+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.464+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.484+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.484+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.494+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.504+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.514+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.524+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.534+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.534+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.544+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.544+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.554+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:56.554+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:56.714+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126956710
06-03 00:12:56.734+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-03 00:12:56.734+0900 W/cluster-home(  860): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-03 00:12:56.744+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:12:56.744+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:12:56.744+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: bg
06-03 00:12:56.784+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126956786
06-03 00:12:57.375+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126957373
06-03 00:12:57.455+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126957449
06-03 00:12:57.455+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:12:57.455+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:12:57.455+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:12:57.465+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:12:57.465+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:12:57.475+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:12:57.475+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:12:57.475+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:12:57.495+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:12:57.495+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:12:57.535+0900 E/TBM     ( 6622): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:12:57.575+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6622, appid: org.example.example
06-03 00:12:57.575+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:12:57.585+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6622)
06-03 00:12:57.725+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(514) > [APP 6622] Event: RESET State: CREATED
06-03 00:12:57.725+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.725+0900 E/EFL     ( 6622): edje<6622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:57.725+0900 E/EFL     ( 6622): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:57.765+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:57.765+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:57.815+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:12:57.815+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:57.825+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:57.835+0900 W/APP_CORE( 6622): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:12:57.835+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:12:57.855+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:57.956+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:12:57.956+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:12:57.956+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:12:57.966+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:12:57.966+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:12:57.966+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:12:57.966+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6622) status(3)
06-03 00:12:57.966+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6622)
06-03 00:12:57.966+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6622, appid: org.example.example, status: fg
06-03 00:12:57.976+0900 W/LFE      (15849): [15849] 26:07:30.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:57.996+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(514) > [APP 6622] Event: RESUME State: CREATED
06-03 00:12:58.006+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:12:58.006+0900 I/APP_CORE( 6622): appcore-efl.c: __do_app(625) > [APP 6622] Initial Launching, call the resume_cb
06-03 00:12:58.006+0900 I/CAPI_APPFW_APPLICATION( 6622): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:58.316+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6622) status(0)
06-03 00:12:58.616+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3160
06-03 00:12:58.616+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:12:58.616+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6622.
06-03 00:12:58.706+0900 E/EFL     ( 6622): ecore_x<6622> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126958706
06-03 00:12:58.886+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6622 pgid = 6622
06-03 00:12:58.886+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6622)
06-03 00:12:58.886+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:58.896+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:58.896+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:12:58.896+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:12:58.957+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:12:58.957+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:12:58.957+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:12:58.957+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6622
06-03 00:12:58.957+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6622
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6622] terminate event is forwarded
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6622, ]
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:12:58.957+0900 I/Tizen::App( 1210): (512) > Not registered pid(6622)
06-03 00:12:58.957+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:12:58.957+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:58.957+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3161
06-03 00:12:58.967+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:12:58.967+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:12:58.977+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6622
06-03 00:12:58.977+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:12:58.977+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:58.977+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:12:58.987+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:58.987+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6622.
06-03 00:12:58.987+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:59.027+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:12:59.027+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:59.027+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:12:59.027+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:12:59.027+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: fg
06-03 00:12:59.047+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:59.047+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:12:59.047+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:59.067+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:12:59.067+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:12:59.077+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:12:59.077+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:12:59.077+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:59.477+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3162
06-03 00:12:59.857+0900 I/UXT     ( 6663): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:13:00.008+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:13:00.028+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.038+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.048+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.048+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.068+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.068+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.088+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.088+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.108+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 00:13:00.108+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:00.108+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 1106622657861149641637
