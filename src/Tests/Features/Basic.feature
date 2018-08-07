Feature: Basic

Scenario: 01 - Search IPhone X
	Given User search item by query "iPhone X 64GB"
	Then User can see item with name "Apple iPhone X 64GB"

Scenario: 02 - Search Contains Corresponding Results
	Given User search item by query "Samsung Galaxy"
	Then All result items contain titles corresponding to query "Samsung"

Scenario: 03 - IPhone X 64GB Summary Details
	Given User search item by query "Apple iPhone X 64GB"
	Then Summary contains string "экран 5.8", разрешение 2436x1125"
	And Summary contains string "двойная камера 12/12 МП, автофокус, F/1.8"
	And Summary contains string "память 64 Гб, без слота для карт памяти"
	And Summary contains string "3G, 4G LTE, LTE-A, Wi-Fi, Bluetooth, NFC, GPS, ГЛОНАСС"
	And Summary contains string "вес 174 г, ШxВxТ 70.90x143.60x7.70 мм"