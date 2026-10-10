# ChartTooltipSeriesQueryArtifacts

> **类型**：static class　**命名空间**：`TCYM.UI.Chart.Visual`　**Chart 版本**：`0.1.1.25`

## 概述

集中定义每系列 Tooltip 查询制品键与生产、消费顺序边界。

## 字段

| 名称 | 说明 |
| --- | --- |
| `ArtifactName` | 每个系列 Tooltip 查询制品使用的稳定名称。 |
| `SeriesProducerOrderExclusiveUpperBound` | 系列查询生产器允许使用的 Visual Order 排他上界。 |
| `TooltipConsumerOrder` | Tooltip 聚合消费器使用的固定 Visual Order。 |

## 方法

### `ForSeries(TCYM.UI.Chart.Model.ChartSeriesOption)`

按系列 canonical RuntimeUid 创建不会受系列重排影响的制品键。

| 参数 | 说明 |
| --- | --- |
| `series` | 当前有效系列或保留同一 RuntimeUid 的回调副本。 |

**返回：** 每系列 Tooltip 查询制品键。
"}),Bb=()=>{const[n,e]=(0,we.useState)(!0),[t,a]=(0,we.useState)({}),[r,o]=RS(eb);return(0,we.useEffect)(()=>{(async()=>{try{const n=await ke.get(`./config/config.json?${Date.now()}`);window.config=n.data;const e=window.config.theme||"light";document.documentElement.setAttribute("data-theme",e),document.documentElement.setAttribute("class",e),document.title=window.config.title||"TCYM.UI 文档",await((n,e)=>{const t=e.lastIndexOf("?"),a=n[-1===t||t<e.lastIndexOf("/")?e:e.slice(0,t)];return a?"function"==typeof a?a():Promise.resolve(a):new Promise((n,t)=>{("function"==typeof queueMicrotask?queueMicrotask:setTimeout)(t.bind(null,new Error("Unknown variable dynamic import: "+e+(5!==e.split("/").length?". Note that variables only represent file names one level deep.":""))))})})(Object.assign({"./assets/scss/theme/dark.scss":()=>OS(()=>Promise.resolve({}),__vite__mapDeps([25]),import.meta.url),"./assets/scss/theme/light.scss":()=>OS(()=>Promise.resolve({}),__vite__mapDeps([26]),import.meta.url)}),`./assets/scss/theme/${e}.scss`);let t=[];try{t=(await ke.get(`./docs/manifest.json?${Date.now()}`)).data||[]}catch{t=[]}let a=[];try{a=(await ke.get(`./chart-docs/manifest.json?${Date.now()}`)).data||[]}catch{a=[]}let r=[];try{r=(await ke.get(`./component-docs/manifest.json?${Date.now()}`)).data||[]}catch{r=[]}const i={};Object.keys(Lb).forEach(n=>{const e=n.replace(/^\.\//,"");i[e]=Lb[n]});const l={};Object.keys(Ob).forEach(n=>{const e=n.replace(/^\.\//,"");l[e]=Ob[n]}),o(n=>({...n,theme:e,docTree:t,docMap:i,chartDocTree:a,chartDocMap:l,componentTree:r,componentMap:{}}))}catch(Yb){}finally{e(!1)}})()},[o]),(0,we.useEffect)(()=>{a({algorithm:"dark"===r.theme?Lf.darkAlgorithm:Lf.defaultAlgorithm})},[r.theme]),n?(0,QI.jsx)("div",{style:{display:"flex",justifyContent:"center",alignItems:"center",height:"100vh"},children:(0,QI.jsx)(yf,{})}):(0,QI.jsx)(gc,{theme:t,locale:zf.default,children:(0,QI.jsx)(Rb,{})})};bc.createRoot(document.getElementById("root")).render((0,QI.jsx)(Bb,{}));export{Ca as $,Zl as A,Sl as B,vc as C,pc as D,gc as E,Ol as F,mi as G,Ni as H,Nl as I,Ci as J,gi as K,Rl as L,$l as M,Gl as N,Xs as O,Hl as P,Er as Q,Tl as R,Ec as S,fc as T,Oi as U,Fi as V,Si as W,uo as X,hi as Y,Xr as Z,op as _,YI as a,xt as at,vd as b,Ay as c,Ge as ct,RS as d,Ee as dt,Bt as et,yf as f,ke as ft,Dp as g,Hp as h,XI as i,kt as it,_l as j,es as k,Oy as l,Le as lt,bm as m,eb as n,Lt as nt,AI as o,ht as ot,Tg as p,f as pt,pi as q,ZI as r,wt as rt,UI as s,ct as st,ob as t,Nt as tt,Yy as u,Re as ut,TC as v,Ic as w,Nc as x,dC as y,yl as z};