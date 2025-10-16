import UserItem from "./UserItem"
import Skeleton from "./Skeleton"

function UserList(props) {
    const skeletonList = [{}, {}, {}, {}, {}, {}, {}, {}, {}, {}]
    
    return (
        <ul className="custom-scrollbar flex flex-col gap-2 rounded-lg h-[400px] p-3 pb-0 pr-2 mr-1 overflow-y-scroll">
            {props.skeleton ? (
                skeletonList.map((_, index) => (
                    <div className="flex flex-col gap-2 border-2 bg-gray-700 border-gray-400 rounded-lg p-2 " key={index}>
                        <Skeleton width={100} height={30} />
                        <Skeleton width={200} height={30} />
                    </div>
                ))
            ) : (
                <>
                    {props.users.map((user, index) => (
                        user.email !== "No email" ? (
                            <UserItem user={user} key={index} />
                        ) : null
                    ))}
                    {props.users.map((user, index) => (
                        user.email === "No email" ? (
                            <UserItem user={user} key={index} />
                        ) : null
                    ))}
                </>
            )}
        </ul>
    )
}

export default UserList