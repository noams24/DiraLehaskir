import Link from "next/link";
import { FC } from "react";
import HouseImage from "./HouseImage";
import CountdownTimer from "./CountdownTimer";
import CurrentBid from "./CurrentBid";
import { Auction } from "@/types";

interface AuctionCardProps {
  auction: Auction;
}

const AuctionCard: FC<AuctionCardProps> = ({ auction }) => {
  // console.log(auction)
  return (
    <Link href={`/auctions/details/${auction.id}`} className="group">
      <div className="w-full bg-gray-200 aspect-w-16 aspect-h-10 rounded-lg overflow-hidden">
        <div>
          <HouseImage imageUrl={auction.imageUrl} />
          <div className="absolute bottom-2 left-2">
            <CountdownTimer auctionEnd={auction.auctionEnd} />
          </div>
          <div className="absolute top-2 right-2">
            <CurrentBid
              reservePrice={auction.reservePrice}
              amount={auction.currentHighBid}
            />
          </div>
        </div>
      </div>
      <div className="flex justify-between items-center mt-4">
        <h3 className="text-gray-700">{auction.city}</h3>
        <p className="font-semibold text-sm">{auction.rooms}</p>
      </div>
    </Link>
  );
};

export default AuctionCard;
