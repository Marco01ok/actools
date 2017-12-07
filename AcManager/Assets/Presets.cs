﻿using System;
using System.IO.Compression;
using AcManager.Tools.Managers.Presets;
using AcTools.Utils.Helpers;

namespace AcManager.Assets {
	public static class DefaultPresets {
        private static byte[] Unpack(string packed) {
            var bytes = Convert.FromBase64String(packed);
            using (var inputStream = new System.IO.MemoryStream(bytes)) {
                return new DeflateStream(inputStream, CompressionMode.Decompress).ReadAsBytesAndDispose();
            }
        }

		public static void Initialize() {
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"Xcq7CoRADEDRf0ktEhRXSCeIaL2FdYbJ4IAPMCMWi/++OoWg3YVzf1BNxsscvgPbZa+9c5v6ZQb6YIoJsBqgDGM/zi7IyuE8FShHfHPrrfSDyHiy41Hl5Q1buYWVgcK6xTQTEKbllXvMvDj+"), @"Ambient Shadows", @"Default");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"XY27CoAwDAD/JbNIUFTIJojo7OAcaYoFH2BbHMR/twoOuh3cwR1QzoORxXUjq3WvjNbemnUByjHGCNgOQAk+/ClbJxu7UFqgFPGvG6OkH0WmoN3m5adrVgKkebJyP/iNwm4Gwri4cX8wzc4L"), @"Ambient Shadows", @"Open Wheelers");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"TY7BDoJADET/Zc/EoEdugjEx8QbRc8EiDWWXdLsHYvx3VwX0OM28eX2Y0w2Bz2TRZCoBE7MP6nKmccmlQk1MOhXOqjg22TZNN+lcFOgj2QL7GS07ahVlpeNSqQhDxBao4KBNt/pqb7JdYiqBRsnZVRNvF/IB+AAD3H+WJX6eqCbBK4LM88eAHAd8GMb31l8pZ7A9qv9qny8="), @"Assists", Controls.ControlsStrings.AssistsPreset_Gamer);
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"VY7LCoMwEEX/ZdZSVOgmO7UUCt1F2vVoxxocE0kmCyn999qHQpf3cu6ZecDpRshnYwlUhxwogSKKK9lMoMTHJWvBxrCRuXJWvGNQ+3SX/jiPw/9S96YT8lunF5MWwhFUtq4qjtL2q79oAqg8gdpjK8bZ7UyWwMWEiHzAEe+08mvKP1/Us6crof/pj5F4EYQ4Tm8XqA0qGe1AEr6a5ws="), @"Assists", Controls.ControlsStrings.AssistsPreset_Intermediate);
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"VY7BDoIwEET/pWdi4MpNMCYm3iB4XnCRDUtL2u2BGP/dYgrEY6fz5u1b3Z4IfCeNKu+BHSbq7MUUTPMeVAItMclSGi3WsMrTUxp7FsZ/shqoF7QHHJYqQZhUnm1UyV664cBaFz4TVVvohIzeNSFryHngC0zwCh6xPvS3V5b+7qgXiw8EGwVXjxwWnJ/mdSyma6lg0COKi+LPFw=="), @"Assists", Controls.ControlsStrings.AssistsPreset_Pro);
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"ZY7LCsJADEX/JesiQ6mis3OUigtBqH5AtKENzkNmplgV/91psSt3uYebk7yh9M6AFDORwcmBXI2T8ty00VIIIPN8RDs0BkEuxnDknvSWbOD4TI0Brc2Fycafqmqxdg/FGP7AptNa4fU2ufaRPEZ2NlWLuRjsWNdsmxSnvQPeK35ROiWKZQbnQGWP6ZvoO/p8AQ=="), @"Baked Shadows", @"Body");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"q1ZyK8rPVbLStTTQM9BRCslXsoKwnIoy0zNK8lKLi5WsjIzAQu6JubmJSlZmYI5jblJmal6JkhWY51mSWpRYkpmfB1RtaGBgUAsA"), @"Baked Shadows", @"Rims");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"fVTLbtswEPwX9lhDkCy/pJsfUVIgbozYSYAGPdDy2mZNiQJJxXGKXvtN/Yr2l7okZVlxgugk7pDD3Z1Z/iQPbKW3JA78drtFroBttprE3X63ReZirfdUwkTsc8VegMRryhW0yJCzTT6mksRalqd1BpJeCcleRK4p54d34HuQmqUOfE12fvhmvVagb4FTzZ7gQ6rzrRXxFdAVN+Woi5wuOaxqZCTpDq7fha5hrSdCyJsC8jp4a7a+ic63Yj+ReKOsQwt5WIjLEpTC7rgLjplfC7pqBI/XYdTwSCGyM+jDvpDY98IP22F2+JikBpAT2JA4tOuFyAG3KiawkAAZsiWDXBuJx4ILLIV8SpIoiKJoQGr4rmiAY/P5CI5outtIUearBurbD1FbTgNwHwJTRelUrFAok1+96JiO0pXYT2kxt27r+FHPZYyhguUbl7FYHAqwv+NyCRktqiTvKS8Nqdc9Rx62TNcWcoq7q2p1EvTOlEkpTlqeQiNeSmk84vbeKRhx1KuxtmVeSrqySVYEGE+eKW2uZ6lSjWPz7DU8FE1Q8XrAbmHNIdUo2rEw7VQ/WbTeoR6Y3tblHc3kGjGSRpQcTBahscNJwiYUGOhU/5H7CRzse71K3uYh23cb/fuHxD3rNrv895vE/YGHjoq6HXxjplSDZJjXOW/gtZ3cF8+FUKW0Yg5Ca8bKCJc0y2iVoFlbZWeC5bo6bjo8T5FwjrNgCfzARW0uVdTVbkS8Rc1KNS25ZgVnZpQtN9pS3BQ0ZfpgOJA4YRy+Ys/RzIWEJwZ770exQTs7IWZCMW2H6rHjmYRxfvyo3esGYa/fQobQxqJOL+x2B0HUbwWh52K9YNAN/XY//H4kuxZiN8SKHk0TfS/qOL6B34/8foARv96aiCcSRybl8RbSnSrRluRzL7tfLr+NsnBK6lk4OaQeMHzzO+/gCU1BzUAm0tbbNnfJykGVser5HeaHS+ufpo8nYn10Lv4mIi3VjNPc3Gisg7FKB9trY/w0LbPSvN8ibxw+C4/EDrYnS78Gv6Cp7L8yD8cbeFjg+4iWcoVbc148a2x19eg+1h1dMH58PF3gRi6ZdgXbq3/9Bw=="), @"Custom Previews", @"GT5-like");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"jVTbcpswEP0X+uoyYAO+vPlGkk5cu3EuD5lOR8ZrW7WMqCTiJJ2+9pv6Fe0vdSUBxnHSKU9oz7LaPecs3507ulQbp+d7zWbDOQe63iinF7bDhjPnK7UnAkZ8n0r6DE5vRZiEhtNndJ0OiXB6SuSH8w4EOeeCPvNUEcaeXuZr/BaEoslbaP3r6WolQV0BI4o+nNx9XOuN3HMgS6YHkuOULBgsK2QgyBYuX4UuYaVGnItpBmkVvNKpJ9H5hu9HAm8U/zeM0/Nc758jFBlzBSBGsC6O1zwFzJSU490+FtgtKKRK6zLkjOPtzrs4Dv1wHI2cCr7JauAwGkdxjOCAJNu14Hm6rKH2QdRQcgSM+8MhAhNJyIQvkVvdXnUINAlkyfcTks2NRdBHgWVGcL67QF4dor5kAh4o7KVjh8HsjKY4Xgu75ddPma07zBewI1nR/y1hORQMHCN3G6qgNJ/Vz3Yhy2CMTphQIfhBmUNowHIhtOI290bCgGGvtbNh4EyQpWmyKIDx+JGQ+nmWSFk/z3fHeJ8foZJVK3MFKwaJQkXL0ZR1xGmCvKNqU81X+swyMRBasBR0Gy1N1EHeE+hAQFn7ASzsuVEhff0jv6m/MuHfv1Dq0PXwKTP//CykmRAFgmJXr1SNrNzjx4zLXGh3uFErsMEzstsRndUJbcCoOuM0xS0wV2t25wlWm+OGWCdENmo6KKIm1Qh4hXrlcpIzRTNG9VL6rnUrn2YkoepJ10DLxZTBR2QbvVkY0/2ardGbVoIZl1SZXbt/33I7UTvsdrtR4Ad+JwjbDd8Nmi0dCjuB3213u51G4La9Vsfzmh4mRZ4fRp/LYpecb/s40b0mCynpmqfT8dpdr+1jJKxSY/6AUlm/byDZyhw96XwKv91I74NK2lunWoSDO14s3gkekwTkDEQszMBNfZko3FOYqtrrfvp0ZrxTW4URX5UnfI15kssZI6nV0sQKHQzX2vNJku9y/Sfmae3jF+EB38Lm4OZj8AIdZd7RRYF3Avcz/Guinezchq/xo0Kqzf8cqa4Yvaas/KXawFQsqLLzmqt//AU="), @"Custom Previews", @"Kunos");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"jVXZlqJIEP0X5rFsZUfqDUVR291yqz79kGIKKQlJJYmoc+Z1vmm+YuaXOgG3Wk6fgRcybmQQy42IP4Ul2jJfeJZEWa4IHYg8nwnPmqFVhBnZsQxQaJMsStAZCs87gBNYESyMvKgJqPDMaHo/h5CCDqHoTCIGMD59AS8gZcgtwffGPl4e7XYJZFOIAUMH+FtTX6t2INjiPJqkFYENhtsr0KAggP2vkD7cMZsQOophdPNvmmt+ks58ktmU/47+v0CE529iVa6bvw2hUJJMlZtnEFIbelyiiFWxIryQCHL1BBHug8SthBsEI5aXpkkw4V4If7TbupK/wg2exw+gVbwcbAA38ChJo+0DWj4cLTLzFTBIABiQLU8w92d2O+Te+mBLsgGIZwVLVNHUK0JhwqFgiyIehqBn58x92uEg7aG1Y3vmbpo1lz1vbbVOznSihl0rqGsnraM689cuptMWznY47sFlb/qdDPezSJu9kV60CXs6wI23dRBj1cVzR2+isaame9RaMNNwlWS/UBN7D+OO7bpGraYGm6Fcn29tHJxXesYW8/Pb6/TsPu0XWRpT33xaSdoW7peH2soxN2NjXItrK9PQN1Jk1FYRVWpHRUlru+hs4KfVa2ipZGKJYtYJ2r2G3RtN1i9eYq3AahR0B6g/OGR2Mhmv+14jbsRWhuyVZ0zkmd19atldq46DDey2XTtG8tHNOq+tdr3vAa83yZqnIRngBkbh0Fs7/jrbOFbL9UNf9nvfnc46s2TcOXrT8K0vepvJFg6ciWopy37f2Xqv+/2a9mZ786A5w8QjL5Jbw8pi1JyLllDyhxcoLorBG90iL6cYFlRqphsYgvhCmQXAaV7iqip/hJY+YvchUPZOWfrk2kFt3oMDRCm5t8Vd1MAppfdumyewgQkJH87vOXMTt48A3Ozx89hNkgd4Fr6HLfIIJvg2p6Zwh6HLeA9dA2NlI35WSJaI+bfgrh1e5qFB8xaJYO6EVK0/NtR7SHyM/mr7AEtYrOqXZvt0qZD++4/wrHPzkqKounkR/vc3V5HUqiGrmsxH9AAwSBH37qN1qSqXRW8dY5KktCipacpSKXVAGIJcVNdKQVHbMUERu/iQ53jmcmszPqCK26JWSgtHLlIlVy2qOOVFS5NBihmKMcrHYhEgnxNkFAMXsVMu4SbaCMMhzzqfCTGFBwSz6j72OEXLUoxJglgx5X5807l1fkeTNEUUdUXSZEVSZKUicWd+Xi/0CQks7vUPsdCum8Vj6JJWl1RZNCuPym1y4PHJVUOt5+uu6UM3SFJOQcHaJLMAe+55MRBuxL/z4Tbc+J5Uv8DbwIXJGNI2LULLbQN64cuFRrfZaUUnp2DLA01tsrue+GebuGkyxiAqUqzKhioW/nLoVg6j5LrrpmGabz4SPdj4IG6QAPp3Gr8Hu5xCxTenjSx+gq2YbylOoDL8Yhm1joznvdigPO+35L4gzC4apWBEN4iVYRe//usX"), @"Custom Previews", @"Light");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"bVTLcpswFP0XuqWMkECAd9gxmc7EE0+cxyLThYyVWBNAjCTyaKfbflO/ov2lXgmMcRKx4Z4jHV2de6Wf3rVs+C1XWsjGm4W+l9dbwRtzJl+ahayk8mbel6KY5/bzRvqmnZBLbD8g56x8elSya3YTth/AXojHvfmMWGnGVnLHvRnyvc0YQDKbPdvJlxVrN+IHIBhFqe8tui2vWXvFHypeGsh75EOEo0/4gpVcr7kqFKutCpxCXr+1/X4LpoYz9ZvpMZNBZ2BvWdVZPIjfM3d7YYAxquO+t2zYtuKDlDd7YJUGNG/ezp0vh2lFxcxKKGW9GOYcoXnVKcXHuTeazysp60nsXDxXbCeax1EA8OKVsWm8LrWexpv6lM/lCaurYzpH+w6nNQuwT7FPZug7YfYfzty7M1e27A23iZAATZtkSqEATy04aD/zA02HBjpdhAb07x9vFkMII4zJAP77bVuCBBkMCvIrZrgSkN17deg0ew2gj1pnKOnj5WsrdadsY9nsLHTO6prZGPWxq/1aisZYkEKS1vJNCcKbklWuYdCAupwGFDsnbFWvoIidXnWVEW0luBrEc3nZslKYN6tAXHnO5MOhBeC3kGWn1xVrXHrUYYO4E7DVLcuu7sBTKNFk8Tt4Lp/4/li1U/IbOOb+waUIfaDzlisDDvXXz5Vj+WoUc0eFJfff7QWzXbOWWhj3xtzHAYkJCkmWYYKyOPFxgBFNCY0oRhilSeSHQZSEKM2yOAujKIaJo9CFlE85uH3/FXyJ0iwkUYaSBOMoIaGPgogmOKIojikiCCckAiykMWxHKcIkw2FGk1HtWlRmSLwHCvkM9Q9dz6QpPcCXaitM/zJYE3/9Bw=="), @"Custom Showroom", @"Default (Fast)");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"bVTdbpswGH0XdssQYHAgdyQN1aRGjZr+XFS7cIjbWDUY2aY/m3a7Z+pTbK+0z8YQ0g4khM+xD5/P+cxP71o09JZKxUTjzSPfK+odo40+Ey/NUnAhvbn3pSwXhbm9kb5pJ+QqNjeQC1I9PUrRNfsJ21/AXrDHg54Qy9zcQKwVIWuxp9489L3tOIBitgeyFy9r0m7ZD0DiMMl8b9ntaE3aK/rAaaWh7pGPwjj5D1+SiqoNlaUktVGBXYjrt7b/xJJIt6f+Y2qsxOk49pbwzuDBJ+buwDQwWnbU91YN2XHqpAawaN7OrS0DUHKi10xKY8UD4eoEWvBOSjrOvVF0wYWoJ2Nr4rkke9Y8jgKAl6+ETKZtKqWm9LY29HFciBNWcTksPno3bFUvwTt5XH6coe6YPowbdrSzZiFN5g01dURBmk1b5JQLpw4M4s+0p8MAu/Y5XRTPHPzn3ZunEA1cUYoc+Pe36QgU5HBhCH1NNJUM6vsob79uzgE0Umstjfrx6rUVqpOmUYIoyvIePSd1TSarbP4bwRptQAylGuO3FahvK8L7pnGoLcyhsRGw0V5Bkp1ad1yzljMqnXghLltSMf1mFJAN6Uw8DBnBaymqTm04aWyF2GJO3AqYjKuqqztwFpKaLP4AL8QTPRzDOyW/gW32HaxKwk900VKpwaT+CNrzsXrVktitwpL77+aQmebZCMW0/c/cI8gqwyhBcZYlcYRR5EPF2QzlWZZhnIU4RH4SYHhHaRgBDs88HaUuhHgqwO/7r2GQQuhhOkOgl2coShMfsBiSz2cZrEtwHCIMWIxTmDZL4jRP8SzG0ah2zbgejrYFSvHszVFkWycfwEu5Y7r/OxgTf/0D"), @"Custom Showroom", @"Default (Nice)");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"bVTLbtswEPwX9aoIJEVZlG+2EwcBYsSI8zgYPdAyExORRIGk8mjRa7+pX9H+UpfUI3ISnrQz5HB3dqmfwY2qxJ3QRqoqmOIwmJU7KSp7ql6qhSqUDqbBt2W3goG+rb8i5zx/etSqqfZfsZfy8WBHxCmeo1kMxMpwvlJ7EUxRGGyGAJLZHPhevax4vZE/ACGIsjBYNDtR8vpaPBQit5D3wGNE6Bf8kufCrIVeal46FaerXrRS5cUeUpHVvjFWS164+tTNW91evuC6q7ZNwww5djd07B0vGodH7CNzf5AWGKsbEQZnFd8VopPqwVn1du4N64Flwe1Kau1MeuCFOYLmRaO1GPbeGjEvoIpR7O0913wvq8dBAPDlK+fjeJ0bMzq2KY/pmRqTptB9+G5qX6ldgKmaf95g7qU9DOV22p0xc+1moRIuCRSl48kZUzhC4/J77WfRn5x0U3V8iHTo3z/Q7CxCsGiaduC/38E0zqIMFqMArrgVrvfmo7rXca8Dxqv2dsZtfPZaK9NoNyRRhia0Rc95WfIuZRf73q+VrCwkESVh4Czf5CC+yXnh5wXFLerz6lB/3nf1GprYmFVTWFkXUuiOm6mrmufSvjmF2DfoVD309sPnUuWNWRe88moTj43FXXvzvCkb8BXaNDr8AZ6rJ3F479wxeQGu+W9wiqJP9KwW2oJH7btE7t6zV6u5LxWObL+79+UGZ62MtP7nsz0hUcySBCc0wTTGJKU0hJQxwxkjCU4JJTQm4UkSAUnwJE1YShgiaTyoXSr1NAPHt+ANStIUMUphK8YJxiGKkjjOMhdOGGEZZkl4Ahsp3JAQFFPCyITRd7UbWdgu+xZYqmcYA9xOD5v08JXeSdv+HZyTv/4D"), @"Custom Showroom", @"Industrial");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"bVTLcpswFP0XunUZkIRA2RnHZDITTzxxHotMFzJWYk0AMZLIo51u+039ivaXeiUwIU6NF9xzpKN7z73iR3CtGnErtJGqCU7iWTCvt1I09lS9NAtVKR2cBF+KIp+7Jxjpm3ZCLpF7gMx5+fSoVdfsJizNs7RgwF7Ix72dEEVxmrEciJXhfKV2IjiJZsFmDCCZzZ7v1MuKtxv5HRASMToLFt1W1Ly9Eg+VKC3kPfJxhMh/+IKXwqyFLjSvYRVyuupFK1Wf7yAVMwSuOnX91vZHL7geau2TMGNSg/7A3vKqc3gYHTN3e2mBsboTs2DZ8G0lBqkDOG/ezrxdB6CouF1JrZ1FD7wyH6C86rQW49obI/LKpf0ee3PPNN/J5nEUALx45Xwar0tjJts29Ud6rqbRxlT6sPjd00OpdgGeav55gbmTdn9cb29Mrt0kNMIlEYd4OjdTKnGWvpd/kH4WPR2FdJip6SbsNnn0z2+QiMIIfnGCB/DvLzclOGTwozAIK26FllDrsbrvp7sbMFyttxP38fK1VabTvuWYxhSESM+c8brmk52+/2slG+tACtk63zclnLApeeXGPYzSHvXJDSjophmY4pp7Bb3szKqrrGwrKfQgD5dEXba8lPbNqWDfqFP1cDAaXgtVdmZd8cYrUo+NB0R9n8uyqzswGNo12XwE5+pJ7MeBOCLPwT7/btzt/ETPW6EtmNVfz8idu3y1mvtyYcv9N3fR3ACtlZHWf4Puv5KQYUoIS1CakoikWTJDYZYxxGKUUUKzJErYzC1DLGMUJ4SmCWJ4FLtQ6mlueymMUoQiFtOUZBGhDKQIyyjF8AexGCepk0KYpSm0ksVZhjAio9a1rOyQeg8U6hlqxSHBMUM0PcCXeitt/43wVv38Bw=="), @"Custom Showroom", @"Showroom (Day)");
			PresetsManager.Instance.RegisterBuiltInPreset(Unpack(@"PY+7CsJAEEV/JUy9LombdydqQLAIprCUFQdc8piwu3mg+O8mYtJMcc4p7ryheNKgierTA1KQ9tZq7BUOBhhkqrKoZ9F0VcVgL2vUMiejrKJmyjeCx2EU+oI5Hve3IkiY4/PIFbEHS34mKnd2il3uMsfl0XyCVWfUQypm9wfHsSXTaYQ08XnA4KCMvFdYDIg2GyG1usOVXuU0sJa6XPgFjXphvvzwo58v"), @"Previews", @"Kunos");
		}
	}
}
