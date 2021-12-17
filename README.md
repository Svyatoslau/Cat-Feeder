Cat Feeder
=====================================

Основные требования к приложению
--------------------------------

Особое место в настольной ролевой игре Dungeons & Dragons занимают бои. Механика игры определяет бой как последовательность раудов, в течении которого каждый участник совершает один ход. Когда каждый участник драки совершил свой ход раунд заканчивается и начинается новый раунд. Очерёдность ходов определяется броском кубика с добавлением некоторого модификатора.
Отслеживание количества раундов и правильной последовательности ходов персонажей, особенно в ходе насыщенного боя в условиях ограниченного времени (один из приёмов что бы добавить игрокам острых эмоций), является достаточно сложным процессом.
Для помощи ведущему игры предлагается разработать ПО для отслеживания инициативы в бою.

Необходимая функциональность:
	User:
	  - Мониторить состояние кормушки
	  - Просмотреть логов
	  - Создать расписание
	  - Назначить расписание на кормушки(у)
	  - Сохранить и редактировать расписание
	  - Ставить метки на кормушки (add/edit/remove)
	  - Экспортировать логи и экспорт/импорт расписания кормёжки 
	Admin:
	  - Зарегистрировать нового пользователя(add/edit/remove)
	  - Добавление новой кормушки(add/edit/remove)
	  - Мониторинг состояния всех кормушек
	  - Просмотр админ логов
	  - Экспортировать логов и экспорт/импорт расписания кормёжки 


Анализ требований
-----------------

![Use case diagram for 'Dungeons & Dragons Initiative Tracker'](/Data/Use case diagram TP (5 semestr).jpeg)

Проектирование
--------------

![Class diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/rLZDRXit4BxpANYKKLiF81X674TDLHH1OQdjeIW2QdTgizcV1Kd9TbE_UycLbjmTaY8L98TS32_dcrdEns-6etqZ5HDgLrVaaPT0eUxK2wsXteAGXB2jL88LYYuRnTNBMoQ1VYQK_a1NvOBoHf5NGegAIKdl7fb1WZW2Fh0Qw89gVzuyQDWemlL_LrSEFmHODLnnflWUD5IyZCBOA6R1mOODeCWu424Q1k9lLW1TtKFNIgvQyNAzkJc-ulEGvIkzBSjPk_rdGJSNVNHi_wqhcO81WgttKBTxcF43DPvvpRJHM_sHDwLrqL6n_JseswgQQTDgsUng46nRWTuyUPqaPkbq6Pv8pwAJQJhejqZNHSzBsy9D-gF3r0S_dmT984wNz3g6mHB679ucBivMa2B7osaoSXYmJvWApu3g0DL8bcYGJr8wsE5R20Y_8qz6o2aefZX515cCi49uBAyKvscYq-mwIh4TYo-7o7psq1ecCseEzx0rY3qlmDSYxA5HJjpom8VEuRPGl6q82Ps-W-DC3jVA3V9QrLqhrCXB02j1BEXQwV_g-_xf0Zajdv7Ja-3AEVtHFs6dEsrIO9rcpUYomzZ-P6DOV0qZ3g-ei8ml9fUWQoSzJ8BWhEB_cet_BDjcRP-9EOeS_aC41mx28FE9pcStIMcAHr-51mdZvKZpdGUWKv6tzPQfbC9xqBkTO8PMp7BGPRCJZIvfBXzJI5UCE72WUzwtEzqcN0j2PlFMmHemJ_Cmm0slOTsn9XBh2w2_y9ghK_WrA6Cwu2hprs4leZaFuRscCRZUHFPrkzV01t2P8FTTPmlZajfWDw6Dk9EATYxKK2fWOkn5F38K4yTZqLRFs7OnsmTuFfuscZnD2Y8cv0qlFYteqlp_4slA2eItesLZCj8YtBPjXOqhyvuzgvp2S3AHD6RZdeXB3ZV4-FLaeCeak3WcsgyKVS2Fqhn-GTyn1SPsY6kq4xGeJLxSK1xbyX49j4Tmkx-XK_tvb-ygdPSs6r9okqcgXUJqZL2p27M8T5j8zeAi1f2k-dDB_MlKTsvHnohPBrzSizD2HTTDVvDDbawERdCFVQpsQsoOT0GzoBgWhko-mcK4DUEDvYWvqc7doPOcT_xbfBfq5gF64Kl4j02xWqNuDoMkspZF-ILsDWNdvkqTdLCDjYHce30SSv3Z5Fo5y3k7fvYathTlMV4fCGEXqND08_qWh-Np5tYPhAnBdWUQKR6JVmy-jayZFJXj1eLn4N9V2j6AMGrIiWUhaI3Ils_lgbQ2DnUuapnrM2RYvDXFdXlAr68ZODSi4r5D3qtZR6izYSAjExf9xmuRQ0-UxwYCNU7cd--nMokcTdBM3obzqL_s8qJ_Rz3DjFjPqVlQESFTevUqZnIqcBW1W_SMkp6Xe9n5pMtNOVEvWdGoIsWofaUCja947wdH18jdj--ZV8rKk5Iya66gffDJva-amFmaCyUditF1eyzyyXtgLm4IJBOai4RdynlCG1I76Xs9NQBU1UUsW9TTz81gYV-90drsS87z9HCKtQFa3JJbhgx-1m00)

Зависимости между проектами
---------------------------

![Component diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/SoWkIImgAStDuUAA3ijCBOzLqDEpKuWEA4ejJiqhIIp9pC-BHP7npKz9pK4LSd7q0GeWQq5L2rA0AiBba9gN0hGK0000)
