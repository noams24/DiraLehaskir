import { FC } from "react";

interface CurrentBidProps {
  amount?: number;
  reservePrice: number;
}

const CurrentBid: FC<CurrentBidProps> = ({ amount, reservePrice }) => {
  const text = amount ? "$" + amount : "אין הצעות";
  const color = amount
    ? amount > reservePrice
      ? "bg-green-600"
      : "bg-amber-600"
    : "bg-red-600";
  return (
    <div
      className={`
  border-2 border-white text-white py-1 px-2 rounded-lg flex
  justify-center ${color}
`}
    >
      {text}
    </div>
  );
};

export default CurrentBid;
