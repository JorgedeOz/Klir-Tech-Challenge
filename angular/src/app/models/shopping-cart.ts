export interface ShoppingCart{
    items: ShoppingCartItem[];
    total: number;
}

export interface ShoppingCartItem{
    productId: number;
    quantity: number;
    total: number;
    promotion: Promotion;
}

export interface Promotion{
    promotionName: string;
    promotionType: number;
    timesApplied: number;
    total: number;
}