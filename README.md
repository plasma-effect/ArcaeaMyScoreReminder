# Arcaea Score Manager
Arcaeaの自分のスコアを人力で管理するツールです。Windowsにのみ対応しています。
# 使い方
## 0.ビルドする
このリポジトリをgit cloneし、Microsoft Visual Studio 2019を用意してScoreManagerプロジェクトをリリースビルドしてください。  
自分で用意すれば「ScoreManagerのプロパティ」から好きなアイコンを設定することもできます。
## 1.譜面データを入力する
まず「譜面データをJSONファイルから入力」ボタンをクリックしてdata.jsonファイルを入力してください(ver 2.4.9までの全譜面に対応しています)
- 譜面データに間違いがあればissueを投げてください。
## 2.スコアデータを入力する
次に「スコア編集」ボタンをクリックし自分の自己ベストのデータを入力してください。これは現状省略できません。
- 自動入力するいいアイデアがあったらissueを投げてください。
## 3.スコアデータを追加する
右下のコンボボックスで曲名と難易度を選択し、テキストボックスにスコアを入力してEnterを押すと、それが自己ベストより高い場合データが更新されます。
# 各種データについて
## ウインドウのMin PotentialとMax Potentialについて
Min PotentialはBest枠の譜面別ポテンシャルの和を40で割った値を表示しています。  
Max Potentialは「Best枠の譜面別ポテンシャルの和」に「譜面別ポテンシャルが最も高い譜面の譜面別ポテンシャルの10倍」を足したものを40で割った値を表示しています。
## フィルター
レベル、難易度、譜面定数、ベストスコアでフィルターができます。ただし譜面定数とベストスコアについては「より大きい」「以上」「と等しい」「以下」「より小さい」のみ選べます(区間でのフィルターには対応していません)
## 目標スコア
「どのくらいのスコアを出せば(どれだけFarを抑えれば)目標を達成できるか」を表示できます。ただし無印Pureによる+1点を考慮せず計算しているので実際の値と異なる場合があります。  
目標については以下の5種類に対応しています。
- 譜面別ポテンシャル
- デフォルトのステップ数
- 《Grievous Lady 対立》(Lv20)を使用したときのステップ数
- 《対立&チュウニペンギン》(Lv20)を使用したときのステップ数
- 《Fracture 光》(Lv20)を使用した時のステップ数
## 曲別集計
各楽曲別のベストスコア、ベストポテンシャル、及びベストスコアから計算されたFarの数を表示します。
## リコメンド
譜面別ポテンシャルが譜面別ポテンシャル30位のそれより大きくなるような楽曲、難易度、目標スコアを表示します。ただし無印Pureによる+1点は考慮していません。表示される楽曲、難易度は以下の優先順位でソートされます。
- 譜面定数が低い順
- 譜面定数が同じ場合許容Far数が多い順

またスコアでフィルターをかけることができます。スコアによるフィルターは以下の4種類があります。
- 9800000未満(ランクEX未満)
- 9950000未満
- PURE MEMORY以外(10000000未満)
- 無制限
## ロールバック
誤ってスコアを登録した場合、その操作をなかったことにできます。消したい登録情報を選択し完了ボタンを押すと、その登録情報が登録される前の状態に戻します。この操作は一度行うと取り消せないので注意して行ってください。
## クリアライン
ノーマルゲージとイージーゲージについて、想起率が一度も0%にも100%にもならなかった場合のTRACK COMPLETE許容Lost数をFar数別に出力します。ただし201Far以上の場合は考慮していません。参考値として利用してください。
# その他FAQ
## このプログラムの著作権はどうなっていますか
このプログラムの著作権はplasma-effectにありますが、MITライセンスで公開しているので改変や再配布などはMITライセンスが許す範囲で行うことができます。ただしMITライセンスの条項にあるようにこのプログラムに対しての保証はいたしません。
## 実行ファイルの配布はしないのですか
しません。
## 他の人のために自分でビルドした実行ファイルを配布していいですか
MITライセンスで許可される事項ですので大丈夫です。ただし上記にあるように保証はいたしません。
## スマホ版やブラウザ版の予定はありますか
そのうちブラウザ版も作りたいですね。スマホ版はAndroid版のみ可能性があります(Apple製品を一つも持ってないのでiOS版が出る見込みはありません)。
